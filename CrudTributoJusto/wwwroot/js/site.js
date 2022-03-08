function addProduto() {
    
}

async function IncluirOutroIdioma() {
    try {
        showLoader();
        let posicao = parseInt($("#listaIdiomas .idiomas__list").last().attr('position')) + 1;

        const url = `${window.location.origin}/curriculo/cursos-idiomas/incluir-outro-idioma/${posicao}`;

        var res = await ajaxRequestReturnHtml(url, 'GET');

        $("#listaIdiomas").append(res);
        LoadSelectsIdioma();
        hideLoader();
    }
    catch (err) {
        hideLoader();
        $.map(err.responseJSON.errors, function (values, index) {
            toast.error(Object.values(values));
        });
    }
}