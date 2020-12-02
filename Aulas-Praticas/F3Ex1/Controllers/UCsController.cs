using System.Collections.Generic;
using System.Linq;
using F3Ex1.Models;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace F3Ex1.Controllers
{
    public class UCsController : Controller
    {
        private static List<Disciplinas> disciplinasList = Disciplinas.getList(); //new List<Disciplinas>();

        // GET
        public ActionResult Index()
        {
            return View(disciplinasList);
        }

        public EditForm Edit(int id)
        {
            Disciplinas? first = null;
            foreach (var uc in disciplinasList)
            {
                if (uc.id == id)
                {
                    first = uc;
                    break;
                }
            }

            var edit = new EditForm {Model = first};
            return edit;
        }


        public ActionResult MostraDisciplinas()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Disciplinas disciplinas)
        {
            disciplinasList.Add(disciplinas);
            return this.Index();
        }

        public ActionResult Detalhes(int id)
        {
            return View(Disciplinas.getDisciplidaPorId(id, disciplinasList));
        }

        public ActionResult Apagar(int id)
        {
            disciplinasList.RemoveAll(item => (item.id == id));

            return this.Index();
        }

        public string Modificar(int id)
        {
            return "Ainda não existe forma de editar uma unidade corrucular.";
        }
    }
}