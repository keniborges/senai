function Excluir(id) {
    var modal = $(".modal");
    $(modal).find('.modal-title').html("Excluir Escola");
    $(modal).find('.modal-body').find('p').html("Você tem certeza que deseja excluir essa escola?");
    $(modal).find('.modal-footer').html('<button type="button" onclick="ExcluirConfirmado('+id+')" class="btn btn-primary">Excluir</button>');
    $(modal).modal('show');
}

function ExcluirConfirmado(id) {
    $.ajax({
        url: 'Colegio/Excluir',
        data: {id : id},
        success: function (data) { 
            if (data == true) {
                alert("Colégio Excluído");
                window.location.href = "colegio/index";
            } else {
                alert("Erro ao Excluir o Colégio");
            }            
        }
    });
}
