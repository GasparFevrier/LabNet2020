setTimeout(function () {
    $(".alert").hide();
}, 3000);

//$(document).ready(function () {
//    $('.alert').click(function () {
//        $(this).remove();
//    });
//});

function DeleteConfirm() {
    if (confirm("Desea Eliminar el Registro"))
        return true;
    else
        return false;
}
