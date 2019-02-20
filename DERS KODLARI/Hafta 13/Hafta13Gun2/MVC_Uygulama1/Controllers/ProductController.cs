using MVC_Uygulama1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Uygulama1.Controllers
{
    public class ProductController : Controller
    {
        /*Get action ve post action olmak üzere iki tane action vardır. 
         * Eğere herhangi bir belirtme eyapılmazsa varsayılan action get actiondır.
         Yani get action view'e değer gönderir ve view'ı çalıştırır.*/


        // GET: Product
        public ActionResult Index()
        {
            /*
             View Methodunun arasına bir değişken vermek o değişkeni model yöntemi ile view'e 
             göndermek demektir.Model yöntemiyle bir anda sadece bir veri gönderilebilir
             */
            List<Product> products =NorthwindModel.Model.Products.ToList();
            
            List<Category> categories = NorthwindModel.Model.Categories.ToList();

            //categoriesViewBag dinamik bir tiptir. Bunu istediğimiz aı verebiliriz.
            //Bu tipin temsil eden alana veriler atanır.
            ViewBag.categoriesViewBag = categories;

            //Model Yöntemi ile veri gönderme view içine yazılır.
            return View(products);
        }
        public ActionResult AddProduct()
        {
            List<Category> categories = NorthwindModel.Model.Categories.ToList();

            List<Supplier> suppliers = NorthwindModel.Model.Suppliers.ToList();

            ViewBag.categoriesVB = categories;
            ViewBag.suppliersVB = suppliers;

            return View();
        }
        [HttpPost]
        // Aşağıdaki alınan parametreler html sayfasında verileri alırken yazılan textbox numeric input formların nameleri ile aynı olmak zorundadır.
        public ActionResult AddProduct(string productName,decimal price,short unitInStock,int cId,int sId)
        {
            Product product = new Product()
            {
                ProductName=productName,
                UnitPrice=price,
                UnitsInStock=unitInStock,
                CategoryID=cId,
                SupplierID=sId
            };
            NorthwindModel.Model.Products.Add(product);
            NorthwindModel.Model.SaveChanges();

            // Aşağıdaki kod kısmında eğer return view(); şeklinde yollarsak sadece bu kodlar çalışacağından categories ve supplier kısımları gelmediğinde hata alacaktık. Ama eturn RedirectToAction("Index"); dersek aşağıdaki return view'e kadar olan kısmı yazmamıza gerek kalmaz
            //List<Category> categories = NorthwindModel.Model.Categories.ToList();

            //List<Supplier> suppliers = NorthwindModel.Model.Suppliers.ToList();

            //ViewBag.categoriesVB = categories;
            //ViewBag.suppliersVB = suppliers;
            // return View();
            return RedirectToAction("Index");
        }
    }
}