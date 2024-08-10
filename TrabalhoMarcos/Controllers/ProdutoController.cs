using Microsoft.AspNetCore.Mvc;

namespace TrabalhoMarcos.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult CadastroProduto()
        {
            return View();
        }
    }
}
