//o codigo ta funfando, logo, não mexer pfvr :).
const dialog = document.querySelector('.dialog')
const toggleDialog = document.querySelector('#toggleDialog')
const fecharDialog = document.querySelector(".fechar")
const containerLista = document.querySelector("#serviceList")
const addServiceButton = document.querySelector("#addService")
const lista = []
// Função para renderizar a lista de serviços
const criaServicos = () => {
    containerLista.innerHTML = ""
    lista.forEach((item, index) => {
        const li = document.createElement("li")
        li.textContent = item
        const editIcon = document.createElement("span")
        editIcon.textContent = "✎"
        const deleteIcon = document.createElement("span")
        deleteIcon.textContent = "❌"
        // Evento de clique para editar o serviço
        editIcon.addEventListener("click", () => {
            const newName = prompt("Digite o novo nome do serviço:")
            if (newName) {
                lista[index] = newName
                criaServicos()
            }
        })
        // Evento de clique para excluir o serviço
        deleteIcon.addEventListener("click", () => {
            if (confirm("Tem certeza que deseja excluir este serviço?")) {
                lista.splice(index, 1)
                criaServicos()
            }
        })
        li.appendChild(editIcon)
        li.appendChild(deleteIcon)
        containerLista.appendChild(li)
    })
}

// Evento de clique para adicionar novo serviço
addServiceButton.addEventListener("click", () => {
    const novoServico = prompt("Digite o nome do novo serviço:")
    if (novoServico) {
        lista.push(novoServico)
        criaServicos()
    }
})
// Renderiza a lista inicial

fecharDialog.addEventListener('click', ()=> {
    dialog.classList.toggle('on')
})

toggleDialog.addEventListener('click',()=> {
    dialog.classList.toggle('on')
})