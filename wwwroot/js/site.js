// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function like()
{
    if(document.getElementById("amei").checked == false){
        document.getElementById("alterar-icone").src="../Feed/img/Like-vermelho.svg";
    }else{
        document.getElementById("alterar-icone").src="../Feed/img/Like.svg";
    }
}