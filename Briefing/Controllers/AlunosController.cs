using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Briefing.Context;
using Briefing.Dao;
using Briefing.Filtros;
using Briefing.Models;

namespace Briefing.Controllers
{
    [AutorizacaoFilter]
    public class AlunosController : Controller
    {
        private AlunosDao alunosDao = new AlunosDao();
        private CidadesDao cidadesDao = new CidadesDao();

        public ActionResult Index()
        {
            return View(alunosDao.Lista());
        }

        public ActionResult Details(int id)
        {
            Aluno aluno = alunosDao.Busca(id);

            if (aluno == null)
            {
                return HttpNotFound();
            }

            ViewBag.IdCidade = new SelectList(cidadesDao.Lista(), "Id", "Nome", aluno.Endereco);

            return View(aluno);
        }

        public ActionResult Create()
        {
            ViewBag.IdCidade = new SelectList(cidadesDao.Lista(), "Id", "Nome");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Aluno aluno)
        {
            if (aluno != null)
            {
                aluno.DataCadastro = DateTime.Now;
                aluno.Mae.DataCadastro = DateTime.Now;
                aluno.Pai.DataCadastro = DateTime.Now;

                alunosDao.Adiciona(aluno);
                return RedirectToAction("Index");
            }

            return View();
        }

        public ActionResult Edit(int id)
        {
            Aluno aluno = alunosDao.Busca(id);
            if (aluno == null)
            {
                return HttpNotFound();
            }

            ViewBag.IdCidade = new SelectList(cidadesDao.Lista(), "Id", "Nome");

            return View(aluno);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Aluno aluno)
        {
            if (aluno != null)
            {
                aluno.Endereco.Id = aluno.IdEndereco;
                aluno.Pai.Id = aluno.IdPai;
                aluno.Mae.Id = aluno.IdMae;

                alunosDao.Edita(aluno);
                return RedirectToAction("Index");
            }

            ViewBag.IdCidade = new SelectList(cidadesDao.Lista(), "Id", "Nome", aluno.Endereco);
            return RedirectToAction("Edit", aluno.Id);
        }

        public ActionResult Delete(int id)
        {
            Aluno aluno = alunosDao.Busca(id);

            if (aluno == null)
            {
                return HttpNotFound();
            }
            return View(aluno);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirme(int id)
        {
            alunosDao.Deleta(id);
            return RedirectToAction("Index");
        }
    }
}
