// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Funções das páginas de login e cadastro.

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