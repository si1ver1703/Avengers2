﻿$(document).ready(function {
    $('#LogIn').click(function () {
        var UserName = $('#inputUserName').val();
        if (UserName) {
            var href = "/Chat?user=" + encodeURIComponent(UserName);
            href = href + "&logOn=true";
            $('#BtnLogin').attr('href', href).click();
            $('#UserName').text(UserName);
        }
    });
});



function OnSuccess(result) {
    scroll();
    ShowLastRefresh();
    setTimeout("Refresh();", 5000);

    $('#SendMessages').keydown(function (e) {
        if (e.keyCode = 13) {
            e.preventDefault();
            $('#btnMessages').click();
        }
    });

    $('#btnMessages').click(function (e) {
        var text = $('#SendMessages').text().val();
        if (text) {
            var href = "/Chat?user=" + encodeURIComponent(UserName).text();
            href = href + "&ChatMessage=" + encodeURIComponent(text).text();
            $('Link').attr("href", href).click();
            $("#txtMessage").empty();
        }
    })

}

function Refresh() {
    var href = "/Chat?user=" + encodeURIComponent(UserName).text();
    $('#') // кнопка для обновления
    setTimeout("Refresh();", 5000);
}

function OnFailure(result) {
    $('#UserName').val("");
    $('#Error').text(result.responseText);
    setTimeout("$('#Error').empty();", 2000);
}

function scroll() {
    var win = $('#Message');
    var height = win[0].scrollHeight;
    win.scrollTop(height);
}

function ShowLastRefresh() {
    var dt = new Date();
    var time = dt.getHours() + ":" + dt.getMinutes() + ":" + dt.getSeconds();
    $('#Last').text("Последнее обновление чата было в " + time);
}