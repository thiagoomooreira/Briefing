

google.charts.load('current', { packages: ['corechart'] });
google.charts.setOnLoadCallback(drawChart);

function drawChart() {
    const divAlunos = document.querySelector('#chartAlunos')
    const divCidades = document.querySelector('#chartCidades')


    //GRAFICO ALUNOS
    var dataAlunos = new google.visualization.DataTable();
    dataAlunos.addColumn('date', 'name');
    dataAlunos.addColumn('number', 'Alunos Cadastrados');
    var dataArrayAlunos = [];

    if (typeof dadosAlunos !== "undefined") {
        $.each(dadosAlunos, function (i, obj) {
            dataArrayAlunos.push([new Date(obj.data), obj.quantidade])
        })

        dataAlunos.addRows(dataArrayAlunos)

        var optionsAlunos = {
            title: 'Alunos Cadastrados',
            curveType: 'function',
            legend: { position: 'bottom' },
            backgroundColor: '#ecf0f1',
        };

        var chartAlunos = new google.visualization.AreaChart(divAlunos);
        chartAlunos.draw(dataAlunos, optionsAlunos)
    }

    

    //GRAFICO CIDADES
    var dataCidades = new google.visualization.DataTable();
    dataCidades.addColumn('string', 'name');
    dataCidades.addColumn('number', 'Quantidade de Alunos');
    var dataArrayCidades = [];

    if (typeof dadosCidades !== "undefined") {
        $.each(dadosCidades, function (i, obj) {
            dataArrayCidades.push([obj.cidade, obj.quantidade])
        })
        dataCidades.addRows(dataArrayCidades)

        var optionsCidades = {
            title: 'Alunos por Cidade',
            curveType: 'function',
            legend: { position: 'bottom' },
            backgroundColor: '#ecf0f1',
        };

        var chart = new google.visualization.ColumnChart(divCidades);
        chart.draw(dataCidades, optionsCidades)
    }
    
}