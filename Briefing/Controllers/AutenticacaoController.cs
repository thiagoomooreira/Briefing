using Briefing.Context;
using Briefing.Dao;
using Briefing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Briefing.Controllers
{
    public class AutenticacaoController : Controller
    {
        private UsuariosDao usuariosDao = new UsuariosDao();
        private CidadesDao cidadesDao = new CidadesDao();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Usuario usuario)
        {
            if(usuario == null)
            {
                return View("Index");
            }

            var eLogado = usuariosDao.VerificaLogin(usuario);
            if (eLogado != null)
            {
                Session["usuarioLogado"] = usuario;
                RedirectToAction("Index", "Home");
            }

            return RedirectToAction("Index","Home");
        }

        public ActionResult Create()
        {
            ViewBag.IdCidade = new SelectList(cidadesDao.Lista(), "Id", "Nome");
            return View();
        }

        [HttpPost]
        public ActionResult Create(Usuario usuario)
        {
            if (usuario != null)
            {
                usuario.DataCadastro = DateTime.Now;
                usuariosDao.Adiciona(usuario);

                return RedirectToAction("Index");
            }

            return View();
        }
    }
}