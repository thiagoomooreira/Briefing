using Briefing.Context;
using Briefing.Dao;
using Briefing.Filtros;
using Briefing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Briefing.Controllers
{
    [AutorizacaoFilter]
    public class AlunosPorCidadesController : Controller
    {
        private AlunosDao alunosDao = new AlunosDao();
        private CidadesDao cidadeDao = new CidadesDao();

        public ActionResult Index()
        {
            return View(cidadeDao.Lista());
        }

        public ActionResult Details(int id)
        {
            return View(alunosDao.ListaPelaCidade(id));
        }
    }
}