// lên top
$(function () {
    $(window).scroll(function () {
        if ($(this).scrollTop() != 0) {
            $('#bttop').fadeIn();
        }
        else {
            $('#bttop').fadeOut();
        }
    }); $('#bttop').click(function () {
        $('body,html').animate({
            scrollTop: 0
        }, 800
        );
    });
});

// chặn nút product
$(document).ready(function () {
    $("#product").click(function (event) {
        event.preventDefault();
    });
});