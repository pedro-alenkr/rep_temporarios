$(document).ready(function() {
    LivroModal();
});

function LivroModal() {
    $.get('/Home/Modal', function(data) {
        $('#LivroModal').html(data);
    });
};

function ShowModal() {
    var div = document.getElementById("LivroModal");

    if (div.hidden == true) 
        div.hidden = false;
}

function MarcarLido() {
    var div = document.getElementById("LivroModal");

    if (div.hidden == true) 
        div.hidden = false;
}