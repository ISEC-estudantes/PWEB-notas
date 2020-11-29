using System.Collections.Generic;
using F3Ex1.Models;
using Microsoft.AspNetCore.Mvc;

namespace F3Ex1.Controllers
{
    public class UCsController : Controller
    {
        // GET
        public ActionResult Index()
        {
            List<Disciplinas> lista = Disciplinas.getList();
            ViewBag.Message = "Esta é a minha mesnagem.";
            // ViewBag.ListaDados = lista;
            return View(lista);
        }

        public ActionResult xpto()
        {
            return View();
        }

        public ActionResult MostraDisciplinas()
        {
            return View();
        }

        public ActionResult Detalhes(int id)
        {
            return View(Disciplinas.getDisciplidaPorId(id, Disciplinas.getList()));
        }
    }
}