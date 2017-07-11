using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoGesprog.Models;

namespace ProjetoGesprog.Controllers
{
    public class ProgramadoresController : Controller
    {
        private GesProgDb context;
        private List<ESTADO> lstEstados;
        public ProgramadoresController()
        {
            this.context = new GesProgDb();
            this.lstEstados = new List<ESTADO>();
        }
        public ActionResult AddProgramadores()
        {
            ViewBag.Title = "Home Page";

            return View();
        }


        //função que busca todos os estados 
        [HttpGet]
        public IEnumerable<ESTADO>getAllStates()
        {
            var consulta= context.ESTADO.AsEnumerable();
            foreach (var item in consulta.ToList())
            {
                new ESTADO
                {
                    ESTADOID = item.ESTADOID,
                    SIGLA = item.SIGLA
                };
            }
            return lstEstados;
        }
    }
}
