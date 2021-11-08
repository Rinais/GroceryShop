using RestaurantApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            customerRepository cr = new customerRepository();
            itemsRepository ir = new itemsRepository();
            paymentTypeRepository pr = new paymentTypeRepository();

            var dropDownObj =new Tuple<IEnumerable<SelectListItem>, IEnumerable<SelectListItem>, IEnumerable<SelectListItem>>(
                cr.getAllCustomers(), ir.getAllItems(), pr.getAllPayments());
            return View(dropDownObj);
        }
    }
}