function mostrarDropdown() {
    var count = document.getElementById('projectCount').value;
    var select = document.getElementById('projectSelect');
    select.innerHTML = ''; 

    for (var i = 1; i <= count; i++) {
        var option = document.createElement('option');
        option.value = i;
        option.text = 'Projeto ' + i;
        select.appendChild(option);
    }

    document.getElementById('pagina01').style.display = 'none';
    document.getElementById('pagina02').style.display = 'block';
}

function gerarOrcamento() {
    // Como faço para linkar com a quantidade de orçamentos que o cliente selecionará?
    document.getElementById('pagina02').style.display = 'none';
    document.getElementById('pagina03').style.display = 'block';
}

function fecharOrcamento() {
    document.getElementById('pagina03').style.display = 'none';
    document.getElementById('pagina01').style.display = 'block';
}
