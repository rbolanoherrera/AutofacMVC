using Services;
using System.Web.Mvc;

namespace EjemploAutofac.Controllers
{
    /// <summary>
    /// Manejo de IOC e inyeccion de dependencias
    /// </summary>
    public class ProductController : Controller
    {
        private readonly IProductService productService;

        public ProductController(IProductService service)
        {
            productService = service;
        }

        // GET: Products
        public ActionResult Index()
        {
            return View(productService.GetProducts());
        }
    }
}