using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task1.Models;
using Task1.Models.Entity;
using Task1.Models.Tables;
using System.Data.SqlClient;

namespace Task1.Controllers
{
    public class ProductController : Controller
    {
        private object products;
        // GET: Product
        public ActionResult Index()
        {
            Database db = new Database();
            var products = db.Products.GetAll();
            return View(products);//
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product p)
        {
            if (ModelState.IsValid)
            {
                Database db = new Database();
                db.Products.Add(p);
                return RedirectToAction("Index");
            }
            return View();
        }
        //
        [HttpGet]
        public ActionResult Update(int id)
        {
            Database db = new Database();
            var p = db.Products.GetId(id);
            return View(p);
        }

        [HttpPost]
        public ActionResult Update(Product p, int id)
        {
            if (ModelState.IsValid)
            {
                Database db = new Database();
                db.Products.update(p, id);
                return RedirectToAction("Index");
            }

            return View();
        }

        public ActionResult Delete(int id)
        {
            Database db = new Database();
            db.Products.delete(id);
            return RedirectToAction("Index");
        }

        public ActionResult ViewInfo(int id)
        {
            Database db = new Database();
            var p = db.Products.GetId(id);
            return View(p);
        }

        [HttpGet]
        public ActionResult Card(int id)
        {
            List<Product> products = null;
            Database db = new Database();
            var product = db.Products.GetProductById(id);

            if (Session["card"] == null)
            {
                products = new List<Product>();
                products.Add(product);
                string json = new JavaScriptSerializer().Serialize(products);
                Session["card"] = json;
                return View(products);
            }
            else
            {
                var item = Session["card"].ToString();
                products = new JavaScriptSerializer().Deserialize<List<Product>>(item);
                products.Add(product);
                string json = new JavaScriptSerializer().Serialize(products);
                Session["card"] = json;
                return View(products);
            }
        }

        [HttpPost]
        public ActionResult Cart()
        {
            List<Product> products = new List<Product>();
            var item = Session["card"].ToString();
            products = new JavaScriptSerializer().Deserialize<List<Product>>((string)item);

            Database db = new Database();
            db.Orders.AddOrderToCard(products);

            Session["card"] = null;

            return RedirectToAction("Index");
        }
    }
}