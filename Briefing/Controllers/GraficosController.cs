using Briefing.Context;
using Briefing.Dao;
using Briefing.Filtros;
using Briefing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Briefing.Controllers
{

    [AutorizacaoFilter]
    public class GraficosController : Controller
    {
        private CidadesDao cidadesDao = new CidadesDao();
        private AlunosDao alunosDao = new AlunosDao();
        private EnderecosDao enderecosDao = new EnderecosDao();

        public ActionResult Index()
        {
            List<DadosChartsAluno> dadosAlunos = new List<DadosChartsAluno>();

            var alunos = alunosDao.Lista().OrderBy(l => l.DataCadastro);
            var count = 1;
            foreach (var a in alunos) {

                if(dadosAlunos.Count() > 0 && a.DataCadastro.ToString("dd/MM/yyyy") == dadosAlunos.Last().data)
                {
                    dadosAlunos.Last().quantidade++;
                }
                else
                {
                    DadosChartsAluno dados = new DadosChartsAluno();
                    dados.data = a.DataCadastro.ToString("MM dd, yyyy");
                    dados.quantidade = count;
                    dadosAlunos.Add(dados);
                }
                count++;
            }

            var dadosCidades = (from aluno in alunosDao.Lista()
                                join endereco in enderecosDao.Lista() on aluno.IdEndereco equals endereco.Id
                                join cidade in cidadesDao.Lista() on endereco.IdCidade equals cidade.Id
                               group cidade by new { cidade.Nome } into g
                               select new
                               {
                                   cidade = g.Key.Nome,
                                   quantidade = g.Count()
                               });

            ViewBag.chartAlunos = dadosAlunos;
            ViewBag.chartCidades = dadosCidades;
            return View();
        }
    }
}