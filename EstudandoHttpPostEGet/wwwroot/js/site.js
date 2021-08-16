var CadastroProduto = new Object();

$(function () {
    $('#Registrar').click(
        function ()
        {
            CadastroProduto.Cadastrar();
        }
    );
});
CadastroProduto.Cadastrar = function ()
{
    var nomeProduto = $('#nomeProduto').val();
    var categoriaProduto = $('#categoriaProduto').val();
    var precoProduto = $('#precoProduto').val();

    var strUrl = "/api/ListaProdutos";

    $.ajax({

        type: "POST",
        url: strUrl,
        data: {nomeProduto: nomeProduto,
            categoriaProduto: categoriaProduto,
            precoProduto: precoProduto},
        dataType: "JSON",
        success: function (data)
        {
            $('#resultado').empty();
            data.forEach(function (entry)
            {
                $('#resultado').append(entry + "<br>");
            });
        }
    });
}