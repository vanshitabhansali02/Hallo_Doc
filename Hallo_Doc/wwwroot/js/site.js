// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function myFunction() {
    var element = document.body;
    element.classList.toggle("dark-mode");
}

    $(window).on('load', function () {
        $('#myModal').modal('show');
    });


    const phoneInputField = document.querySelectorAll("input[type='tel']");
    for (var i = 0; i < phoneInputField.length; i++) {
        const phoneInput = window.intlTelInput(phoneInputField[i], {
        utilsScript:
    "https://cdnjs.cloudflare.com/ajax/libs/intl-tel-input/17.0.8/js/utils.js",
        });
    }



