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
    public class CidadesController : Controller
    {
        private CidadesDao cidadesDao = new CidadesDao();

        public ActionResult Index()
        {
            return View(cidadesDao.Lista());
        }

        public ActionResult Details(int id)
        {
            Cidade cidade = cidadesDao.Busca(id);
            if (cidade == null)
            {
                return HttpNotFound();
            }
            return View(cidade);
        }

        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,EstadoNome")] Cidade cidade)
        {
            if (cidade != null)
            {
                cidadesDao.Adiciona(cidade);
                return RedirectToAction("Index");
            }

            return View(cidade);
        }


        public ActionResult Edit(int id)
        {
            Cidade cidade = cidadesDao.Busca(id);
            if (cidade == null)
            {
                return HttpNotFound();
            }

            return View(cidade);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,EstadoNome")] Cidade cidade)
        {
            if (cidade != null)
            {
                cidadesDao.Edita(cidade);
                return RedirectToAction("Index");
            }
            return View(cidade);
        }

        public ActionResult Delete(int id)
        {
            Cidade cidade = cidadesDao.Busca(id);
            if (cidade == null)
            {
                return HttpNotFound();
            }
            return View(cidade);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cidade cidade = cidadesDao.Busca(id);
            cidadesDao.Deleta(cidade);
            return RedirectToAction("Index");
        }
    }
}
