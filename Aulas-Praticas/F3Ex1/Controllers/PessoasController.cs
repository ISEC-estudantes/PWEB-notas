using Microsoft.AspNetCore.Mvc;

namespace F3Ex1.Controllers
{
    public class PessoasController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}