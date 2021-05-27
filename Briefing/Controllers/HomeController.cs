using Briefing.Context;
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
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}