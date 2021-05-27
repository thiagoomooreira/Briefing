using iTextSharp.text;
using iTextSharp;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Briefing.Context;
using Briefing.Filtros;
using Briefing.Dao;

namespace Briefing.Controllers
{
    [AutorizacaoFilter]
    public class RelatoriosController : Controller
    {

        private AlunosDao alunosDao = new AlunosDao();
        private CidadesDao cidadesDao = new CidadesDao();

        public ActionResult Index()
        { 
            return View();
        }

        public FileResult relatorioAlunos() {

            Document doc = new Document(PageSize.A4);
            //doc.SetMargins(40, 40, 40, 80);
            doc.AddCreationDate();

            string caminho = Request.MapPath("~\\RelatorioGerado/relatorio.pdf");
            
            PdfWriter writer = PdfWriter.GetInstance(doc, new
            FileStream(caminho, FileMode.Create));

            PdfPTable table = new PdfPTable(5);

            table.AddCell("Aluno");
            table.AddCell("CPF");
            table.AddCell("Idade");
            table.AddCell("Sexo");
            table.AddCell("Data de Nascimento");

            foreach (var aluno in alunosDao.Lista()) {

                table.AddCell(aluno.Nome);
                table.AddCell(aluno.Cpf);
                table.AddCell(aluno.Idade.ToString());
                table.AddCell(aluno.Sexo);
                table.AddCell(aluno.DataNascimento.ToString());
            }
            string dados = "";
            Paragraph paragrafo = new Paragraph(dados,new Font(Font.NORMAL, 20));
            paragrafo.Add("Relatório de Alunos");

            doc.Open();
            doc.Add(paragrafo);
            doc.Add(new Paragraph(" "));
            doc.Add(table);
            doc.Close();

            byte[] bytes = System.IO.File.ReadAllBytes(caminho);

            var result = new FilePathResult(caminho, "application/pdf")
            {
                FileDownloadName = "relatorioAlunos.pdf"
            };

            return result;
        }

        public FileResult relatorioCidades()
        {

            Document doc = new Document(PageSize.A4);
            //doc.SetMargins(40, 40, 40, 80);
            doc.AddCreationDate();

            string caminho = Request.MapPath("~\\RelatorioGerado/relatorio.pdf");

            PdfWriter writer = PdfWriter.GetInstance(doc, new
            FileStream(caminho, FileMode.Create));

            PdfPTable table = new PdfPTable(2);

            table.AddCell("Nome");
            table.AddCell("Estado");

            foreach (var cidade in cidadesDao.Lista())
            {
                table.AddCell(cidade.Nome);
                table.AddCell(cidade.EstadoNome);
            }
            string dados = "";
            Paragraph paragrafo = new Paragraph(dados, new Font(Font.NORMAL, 20));
            paragrafo.Add("Relatório de Cidades");

            doc.Open();
            doc.Add(paragrafo);
            doc.Add(new Paragraph(" "));
            doc.Add(table);
            doc.Close();

            byte[] bytes = System.IO.File.ReadAllBytes(caminho);

            var result = new FilePathResult(caminho, "application/pdf")
            {
                FileDownloadName = "relatorioCidades.pdf"
            };

            return result;
        }

        public FileResult relatorioAlunosPorCidade()
        {

            Document doc = new Document(PageSize.A4);
            //doc.SetMargins(40, 40, 40, 80);
            doc.AddCreationDate();

            string caminho = Request.MapPath("~\\RelatorioGerado/relatorio.pdf");

            PdfWriter writer = PdfWriter.GetInstance(doc, new
            FileStream(caminho, FileMode.Create));

            doc.Open();

            Paragraph paragrafo = new Paragraph("", new Font(Font.NORMAL, 20));
            paragrafo.Add("Relatório de Alunos por Cidade");
            doc.Add(paragrafo);
            doc.Add(new Paragraph(" "));

            var cidades = cidadesDao.Lista();
            var alunos = alunosDao.Lista();
            foreach (var cidade in cidades)
            {
                Paragraph title = new Paragraph("", new Font(Font.NORMAL, 16));
                title.Add(cidade.Nome);
                doc.Add(title);
                doc.Add(new Paragraph(" "));

                PdfPTable table = new PdfPTable(7);

                table.AddCell("Aluno");
                table.AddCell("CPF");
                table.AddCell("Idade");
                table.AddCell("Sexo");
                table.AddCell("Data de Nascimento");
                table.AddCell("Nome");
                table.AddCell("Estado");

                foreach (var aluno in alunos.Where(l=>l.Endereco.IdCidade == cidade.Id))
                {
                    table.AddCell(aluno.Nome);
                    table.AddCell(aluno.Cpf);
                    table.AddCell(aluno.Idade.ToString());
                    table.AddCell(aluno.Sexo);
                    table.AddCell(aluno.DataNascimento.ToString());
                    table.AddCell(cidade.Nome);
                    table.AddCell(cidade.EstadoNome);
                }

                doc.Add(table);
            }

            doc.Close();

            byte[] bytes = System.IO.File.ReadAllBytes(caminho);

            var result = new FilePathResult(caminho, "application/pdf")
            {
                FileDownloadName = "relatorioAlunosPorCidade.pdf"
            };

            return result;
        }
    }
}