using MVC_Template.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Template.Controllers
{
    public class ProductController : Controller
    {
        NorthwindContext _model = new NorthwindContext();

        // GET: Product
        public ActionResult Index()
        {
            List<Product> product = _model.Products.ToList();
            return View(product);
        }
    }
}