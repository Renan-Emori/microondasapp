$(function () {
    $("#btnclose").click(() => {
        var tmp = $("#tmp").val();
        var ptnc = $("#ptnc").val();
        if (ptnc == '') {
            ptnc += 10
        }
        var tmp1 = parseInt(tmp);
        var ptnc1 = parseInt(ptnc);
        if (tmp1 <= 120 && ptnc <= 10) {
            $("#myForm").hide();
            $("#btnclose").hide();
            $("#btnclose2").hide();
            $("#myForm3").show().text("Potência " + ptnc);
            $("#btnadd").show();
            $("#btnstop").show();
            var downloadTimer = setInterval(function () {
                if (tmp1 <= 0) {
                    clearInterval(downloadTimer);
                    document.getElementById("countdown").innerHTML = "Aquecimento concluído";
                } else {
                    document.getElementById("countdown").innerHTML = tmp1 + " segundos restantes.";
                    for (var i = 0; i <= ptnc1; i++) {
                        $("#pontos").append("-");
                    }
                    $("#pontos").append(" ");
                }
                tmp1 -= 1;
            }, 1000);
            $("#btnadd").click(() => {
                tmp1 += 30
            })
            $("#btnstop").click(() => {
                tmp1 = 0
                $("#pontos").hide()
            })
        } else if (tmp > 120) {
            window.alert("Insira um tempo adequado.")
        } else if (tmp > 10) {
            window.alert("Insira uma potencia adequada.")
        } else {
            window.alert("Insira um tempo e potencia adequados.")
        }

        
        console.log(tmp1, ptnc1);
    })  
})
$(function () {
    $("#btnclose2").click(() => {
        var tmp1 = 30;
        var ptnc1 = 10;
        $("#myForm").hide();
        $("#btnclose").hide();
        $("#btnclose2").hide();
        $("#myForm3").show().text("Potência " + ptnc1);
        $("#btnadd").show();
        $("#btnstop").show();
        var downloadTimer = setInterval(function () {
            if (tmp1 <= 0) {
                clearInterval(downloadTimer);
                document.getElementById("countdown").innerHTML = "Aquecimento concluído";
            } else {
                document.getElementById("countdown").innerHTML = tmp1 + " segundos restantes.";
                for (var i = 0; i <= ptnc1; i++) {
                    $("#pontos").append("-");
                }
                $("#pontos").append(" ");
            }
            tmp1 -= 1;
        }, 1000);
        $("#btnadd").click(() => {
            tmp1 += 30
        })
        $("#btnstop").click(() => {
            tmp1 = 0
            $("#pontos").hide()
        })
    })
    
})



$('.close-alert').click(() => {
    $('.alert').hide('hide');
});

$(function () {
        $("input[name=nmbrbtn]").click(function () {
            $("#tmp").val($("#tmp").val() + $(this).val())
        })
});

$(function () {
    $("input[name=nmbrbtn2]").click(function (event) {
        event.preventDefault();
        $("#ptnc").val($("#ptnc").val() + $(this).val())
    })
});

