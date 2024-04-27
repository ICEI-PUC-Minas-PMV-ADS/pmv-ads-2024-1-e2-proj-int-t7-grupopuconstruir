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
