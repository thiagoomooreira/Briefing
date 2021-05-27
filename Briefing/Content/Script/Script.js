
$(function () {
    //Executa a requisição quando o campo username perder o foco
    $('#cpfAluno').blur(function () {
        if (!validaCpf($('#cpfAluno').val())) {
            $(".cpf_aluno").removeClass("hide")
        } else {
            $(".cpf_aluno").addClass("hide")
        }
    });

    $('#cpfPai').blur(function () {
        if (!validaCpf($('#cpfPai').val())) {
            $(".cpf_pai").removeClass("hide")
        } else {
            $(".cpf_pai").addClass("hide")
        }
    });

    $('#cpfMae').blur(function () {
        if (!validaCpf($('#cpfMae').val())) {
            $(".cpf_mae").removeClass("hide")
        } else {
            $(".cpf_mae").addClass("hide")
        }
    });
});

function validaCpf(cpf) {
    var cpf = cpf.replace(/[^0-9]/g, '').toString();
    if (cpf.length == 11) {
        var v = [];

        //Calcula o primeiro dígito de verificação.
        v[0] = 1 * cpf[0] + 2 * cpf[1] + 3 * cpf[2];
        v[0] += 4 * cpf[3] + 5 * cpf[4] + 6 * cpf[5];
        v[0] += 7 * cpf[6] + 8 * cpf[7] + 9 * cpf[8];
        v[0] = v[0] % 11;
        v[0] = v[0] % 10;

        //Calcula o segundo dígito de verificação.
        v[1] = 1 * cpf[1] + 2 * cpf[2] + 3 * cpf[3];
        v[1] += 4 * cpf[4] + 5 * cpf[5] + 6 * cpf[6];
        v[1] += 7 * cpf[7] + 8 * cpf[8] + 9 * v[0];
        v[1] = v[1] % 11;
        v[1] = v[1] % 10;

        //Retorna Verdadeiro se os dígitos de verificação são os esperados.
        if ((v[0] != cpf[9]) || (v[1] != cpf[10])) {
            return false;
        }

        return true;
    }
    else {

        return false;
    }
}


$(document).ready(function () {
    $("#cpfAluno").mask('000.000.000-00', { reverse: true });
    $("#cpfPai").mask('000.000.000-00', { reverse: true });
    $("#cpfMae").mask('000.000.000-00', { reverse: true });

});