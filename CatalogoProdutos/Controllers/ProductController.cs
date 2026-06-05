using Microsoft.AspNetCore.Mvc;

namespace CatalogoProdutos.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            List<string> produtos = new List<string>
            {
                "Filtro de Ar Esportivo",
                "Turbo Garret GTX",
                "Kit Nitrous NOS",
                "Pastilhas de Freio Brembo",
                "Velas Iridium NGK"
            };

            List<double> precos = new List<double>
            {
                49.90,
                3200.00,
                1800.00,
                89.90,
                65.00
            };

            ViewBag.Produtos = produtos;
            ViewBag.Precos = precos;

            return View();
        }
    }
}