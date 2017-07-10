using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoGesprog.Controllers
{
    public class ProgramadoresController : Controller
    {
        public ActionResult AddProgramadores()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
