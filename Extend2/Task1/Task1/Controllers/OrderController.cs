using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task1.Models;

namespace Task1.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        [Authorize]
        public ActionResult Order()
        {
            Database db = new Database();
            var order = db.Orders.orderrder();
            return View(order);
        }

        public ActionResult Orders()
        {
            Entities db = new Entities();
            var orders = db.Orders.ToList();
            return View(orders);
        }

        public ActionResult Details(int Id)
        {
            Entities db = new Entities();
            var details = (from o in db.Orders
                           where o.Id == Id
                           select o).FirstOrDefault();
            return View(details);
        }


        public ActionResult CancelOrder(int id)
        {
            Database db = new Database();
            db.Orders.CancelOrder(id);
            return RedirectToAction("Orders");


        }
    }
}