using EjemploAutofac.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EjemploAutofac.Controllers
{
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