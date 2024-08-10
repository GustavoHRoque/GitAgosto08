using Microsoft.AspNetCore.Mvc;

namespace TrabalhoMarcos.Controllers
{
    public class NossoProjetoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
