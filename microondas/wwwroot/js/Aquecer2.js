$(function () {
    $("#btnstarta").click(() => {
        var tmpa = $("#tmpa").val();
        var ptnca = $("#ptnca").val();
        var tmpa1 = parseInt(tmpa);
        var ptnca1 = parseInt(ptnca);
        var id = $("#myid").val();
        $("#tmpa1").hide();
        $("#btnstop1").show();
        if (id > 5) {
        $("#btnadd1").show();
        }
        var downloadTimer = setInterval(function () {
            if (tmpa1 <= 0) {
                clearInterval(downloadTimer);
                document.getElementById("countdown").innerHTML = "Aquecimento concluído";
            } else {
                document.getElementById("countdown").innerHTML = tmpa1 + " segundos restantes.";
                for (var i = 0; i <= ptnca1; i++) {
                    $("#pontos").append("-");
                }
                $("#pontos").append(" ");
            }
            tmpa1 -= 1;
        }, 1000);
        $("#btnadd1").click(() => {
            tmpa1 += 30
        })
        $("#btnstop1").click(() => {
            tmpa1 = 0
            $("#pontos").hide()
        })
    })
})