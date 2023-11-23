$(document).ready(function () {
    configurarMenu();
});

function configurarMenu(){
    $("#btnCloseMenu").click(function () {
        console.log('clique');
      $(".box-links").fadeOut();
    });

    $("#btnOpenMenu").click(function () {
        console.log('clique');
      $(".box-links").fadeIn();
    });
}