// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Funções das páginas de login e cadastro.
/*
let btnLogin = document.getElementById("btnLogin");
let btnCadastro = document.getElementById("btnCadastro");
let btnRecuperarSenha = document.getElementById("btnRecuperarSenha");
let blocoNome = document.getElementById("blocoNome");
let blocoTelefone = document.getElementById("blocoTelefone");
let tituloLogin = document.getElementById("tituloLogin");
let popupRecuperarSenha = document.getElementById("popupRecuperarSenha");

btnLogin.onclick = function () {
    blocoNome.hidden = true;
    blocoTelefone.hidden = true;
    btnRecuperarSenha.hidden = false;
    tituloLogin.innerHTML = "Login";
    btnLogin.classList.remove("btn-disable");
    btnCadastro.classList.add("btn-disable");
}

btnCadastro.onclick = function () {
    blocoNome.hidden = false;
    blocoTelefone.hidden = false;
    btnRecuperarSenha.hidden = true;
    tituloLogin.innerHTML = "Cadastro";
    btnLogin.classList.add("btn-disable");
    btnCadastro.classList.remove("btn-disable");
}
*/
// Funções da página de projetos.
//campo com valor
$(function () {
    $('[type=money]').maskMoney({
        thousands: '.',
        decimal: ','
    });
})
//data dd-mm-yyyy
function mydate() {
    //alert("");
    document.getElementById("dt").hidden = false;
    document.getElementById("ndt").hidden = true;
}
function mydate1() {
    d = new Date(document.getElementById("dt").value);
    dt = d.getDate();
    mn = d.getMonth();
    mn++;
    yy = d.getFullYear();
    document.getElementById("ndt").value = dt + "/" + mn + "/" + yy
    document.getElementById("ndt").hidden = false;
    document.getElementById("dt").hidden = true;
}


// Funções da página de orçamento.
function generateFields() {
    var count = document.getElementById('contaProjeto').value;
    var form2 = document.getElementById('form2');
    var html = '';

    for (var i = 0; i < count; i++) {
        html += '<label class="label-bottom" for="project' + (i + 1) + '">Projeto ' + (i + 1) + '</label><br/>';
        html += '<input type="text" class="form-outline form-control form-control-lg form-projeto" id="project' + (i + 1) + '" name="project' + (i + 1) + '" placeholder="Nome do projeto"><br/>';
    }

    form2.innerHTML = html;
    form2.style.display = 'block';
}

function gerarOrcamento() {
    // Aqui conecta no backend
}

//Funções Material

document.addEventListener("DOMContentLoaded", function() {
    const form = document.getElementById("material-form");
    const materiaisList = document.getElementById("materiais-list");

    let materiais = [];

    // Função para renderizar os materiais na tabela
    function renderMateriais() {
        materiaisList.innerHTML = "";

        materiais.forEach((material, index) => {
            const tr = document.createElement("tr");
            tr.innerHTML = `
                <td>${material.nome}</td>
                <td>${material.descricao}</td>
                <td>${material.preco}</td>
                <td class="action-buttons">
                    <button onclick="editMaterial(${index})">Editar</button>
                    <button onclick="deleteMaterial(${index})">Excluir</button>
                </td>
            `;
            materiaisList.appendChild(tr);
        });
    }

    // Função para adicionar ou atualizar um material
    function addOrUpdateMaterial(event) {
        event.preventDefault();

        const id = document.getElementById("material-id").value;
        const nome = document.getElementById("nome").value;
        const descricao = document.getElementById("descricao").value;
        const preco = parseFloat(document.getElementById("preco").value);

        if (nome.trim() === "" || descricao.trim() === "" || isNaN(preco)) {
            alert("Preencha todos os campos corretamente.");
            return;
        }

        const material = { id, nome, descricao, preco };

        if (id === "") {
            materiais.push(material);
        } else {
            materiais[id] = material;
        }

        form.reset();
        renderMateriais();
    }

    // Função para editar um material
    function editMaterial(index) {
        const material = materiais[index];
        document.getElementById("material-id").value = index;
        document.getElementById("nome").value = material.nome;
        document.getElementById("descricao").value = material.descricao;
        document.getElementById("preco").value = material.preco;
    }

    // Função para excluir um material
    function deleteMaterial(index) {
        if (confirm("Tem certeza que deseja excluir este material?")) {
            materiais.splice(index, 1);
            renderMateriais();
        }
    }

    // Adicionar evento de submit ao formulário
    form.addEventListener("submit", addOrUpdateMaterial);

    // Exemplo de materiais pré-carregados (pode ser substituído pela integração com o backend)
    materiais.push({ nome: "Tijolo", descricao: "9 furos un", preco: 1.89 });
    materiais.push({ nome: "Tijolo", descricao: "6 furos/meio tijolo un", preco: 0.92  });
    materiais.push({ nome: "Tijolo", descricao: "8 furos un", preco: 1.32 });
    materiais.push({ nome: "Cimento", descricao: "Saco de cimento 50kg", preco: 31.00 });
    materiais.push({ nome: "Rejunte", descricao: "cerâmica 5kg", preco: 42.90 });
    materiais.push({ nome: "Telha", descricao: "Telha Colonial un", preco: 7.20 });
    materiais.push({ nome: "Telha", descricao: "Telha Ondina 4m", preco: 26.90 });
    materiais.push({ nome: "Telha", descricao: "Telha Romana un", preco: 2.47 });
    materiais.push({ nome: "Argamassa", descricao: "AC3 externo cinza 20kg", preco: 37.00 });
    materiais.push({ nome: "Argamassa", descricao: "Porcelanato cinza 20kg", preco: 27.50 });
    materiais.push({ nome: "Argamassa", descricao: "AC3 externo cinza 20kg", preco: 37.00 });
    materiais.push({ nome: "Areia grossa/média", descricao: "m²", preco: 120.00 });
    materiais.push({ nome: "Areia fina", descricao: "m²", preco: 160.00 });
    // Renderizar os materiais na inicialização
    renderMateriais();
});
