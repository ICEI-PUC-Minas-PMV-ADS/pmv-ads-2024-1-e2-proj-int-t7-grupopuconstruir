//o codigo ta funfando, logo, não mexer pfvr :).
const dialog = document.querySelector('.dialog')
const toggleDialog = document.querySelector('#toggleDialog')
const fecharDialog = document.querySelector(".fechar")
const containerLista = document.querySelector("#serviceList")
const addDialog = document.querySelector('.criar')
const lista = []
let indexValue = undefined
// Função para renderizar a lista de serviços
const criaServicos = () => {
    containerLista.innerHTML = ""
    lista.forEach((item, index) => {
        const li = document.createElement("li")
        li.classList.add('lista__item')
        li.textContent = item
        const editIcon = document.createElement("img")
        editIcon.classList.add("editIcon")
        editIcon.src = "./assets/editIcon.svg"
        const deleteIcon = document.createElement("img")
        deleteIcon.classList.add("delIcon")
        deleteIcon.src = "./assets/deleteIcon.svg"
        const div = document.createElement("div")
        div.classList.add("icons__container")
        // Evento de clique para editar o serviço
        editIcon.addEventListener("click", () => {
            dialog.classList.toggle('on')
            const inputDialog = document.querySelector('.inputDialog')
            dialogFc('Editar serviço', 'Salvar', 'Editar o seu serviço', 'editar')
            inputDialog.value = item
            indexValue = index
        })
        // Evento de clique para excluir o serviço
        deleteIcon.addEventListener("click", ()=> {
            dialog.classList.toggle('on')
            document.querySelector('.inputDialog').classList.add('off')
            dialogFc('Deletar servico', 'Remover', 'Você realmente deseja remover esse serviço?', 'del')
            indexValue = index
        })
        div.appendChild(editIcon)
        div.appendChild(deleteIcon)
        li.appendChild(div)
        containerLista.appendChild(li)
    })
}

// Renderiza a lista inicial
fecharDialog.addEventListener('click', ()=> {
    dialog.classList.toggle('on')
})

toggleDialog.addEventListener('click',()=> {
    const inputDialog = document.querySelector('.inputDialog')
    dialogFc('Criar serviço', 'Criar serviço', 'Digite o nome do novo serviço.', '')
    dialog.classList.toggle('on')
    inputDialog.value = ""
    if(inputDialog.classList[1]) {
        inputDialog.classList.remove('off')
    }
})

addDialog.addEventListener('click',()=> {
    const inputDialog = document.querySelector('.inputDialog')
    if(addDialog.value === 'editar'){
        lista[indexValue] = inputDialog.value
        criaServicos()
    } else if(addDialog.value === 'del') {
        lista.splice(indexValue, 1)
        criaServicos()
    } else {
        lista.push(inputDialog.value)
        criaServicos()
        inputDialog.value = ""
    }
    dialog.classList.toggle('on')
})
const dialogFc = (title, botaoText, paragraph, botaoType) => {
    const titleDOM = document.querySelector('.title__dialog')
    const buttonDialog = document.querySelector('.criar')
    const pDialog = document.querySelector('.p__dialog')
    titleDOM.textContent = title
    buttonDialog.textContent = botaoText
    pDialog.textContent = paragraph

    buttonDialog.setAttribute('value', botaoType)
}