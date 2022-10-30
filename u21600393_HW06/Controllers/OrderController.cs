using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using u21600393_HW06.Models;
using PagedList.Mvc;
using PagedList;


namespace u21600393_HW06.Controllers
{
    public class OrderController : Controller
    {
        private BikeStoresEntities1 db = new BikeStoresEntities1();

        // GET: Order
        public  ActionResult Index(string currentFilter, string searchString, int ?page)
        {

            var products = db.order_items.Include(p => p.product).Include(p => p.order).ToList();

            int pageSize = 10;
            int pageNumber = (page ?? 1);

            return View(products.ToList().ToPagedList(pageNumber, pageSize));
        }
    }
}