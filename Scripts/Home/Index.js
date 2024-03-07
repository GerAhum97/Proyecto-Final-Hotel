
// Shorthand for $( document ).ready()

swal("Bienvenido a la página principal del Hotel San José!")
$(function () {
    var habitacionPrecios = {
        "1": 100,
        "2": 250,
        "3": 300,
        "4": 400,
        "5": 50,
        "6": 25
    };

    $("#NombreHabitacion").change(function () {
        var selectedValue = $(this).val(); 
        var precio = habitacionPrecios[selectedValue];  

        $("#Precio").val(precio);
        $("#Precio").prop("disabled", true);
    });

    $("#btnGuardarHabitacion").click(function () {
        $("#Precio").prop("disabled", false);
        var formData = $("#form-habitacion").serialize();
        $("#Precio").prop("disabled", true);

        $.ajax({
            url: urlGuardarHabitacion,
            data: formData,
            method: "POST",
            success: function (data) {

                swal( "¡Exelente!", data.msg, "success" );

            },
            error: function (data) {

                swal( "¡Error!", data.responseJSON.msg, "error" );

            },
        })

    });



});
