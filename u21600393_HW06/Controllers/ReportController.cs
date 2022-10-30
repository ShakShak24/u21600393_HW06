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

namespace u21600393_HW06.Controllers
{
    public class ReportController : Controller
    {
        private BikeStoresEntities1 db = new BikeStoresEntities1();
        // GET: Report
        public async Task<ActionResult> Index()
        {
            var order = db.orders.Include(o => o.customer).Include(o => o.staff).Include(o => o.store);
            return View(await order.ToListAsync());
        }
    }
}