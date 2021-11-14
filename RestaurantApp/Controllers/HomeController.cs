using RestaurantApp.Repositories;
using System;
using RestaurantApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestaurantApp.viewModel;

namespace RestaurantApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        private RestaurantDBEntities1 restaurant;
        public HomeController()
        {
            restaurant = new RestaurantDBEntities1();
        }
        public ActionResult Index()
        {
            customerRepository cr = new customerRepository();
            itemsRepository ir = new itemsRepository();
            paymentTypeRepository pr = new paymentTypeRepository();

            var dropDownObj =new Tuple<IEnumerable<SelectListItem>, IEnumerable<SelectListItem>, IEnumerable<SelectListItem>>(
                cr.getAllCustomers(), ir.getAllItems(), pr.getAllPayments());
            return View(dropDownObj);
        }
        [HttpGet]
        public JsonResult getItemById(int itemId)
        {
            var unitPrice = restaurant.items.FirstOrDefault(m => m.itemId == itemId).itemPrice;
            return Json(unitPrice, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult Index(ordersViewModel detailsViewModel)
        {
            OrderRepository orderRepository = new OrderRepository();
            orderRepository.AddItems(detailsViewModel);
            return Json("successfully added", JsonRequestBehavior.AllowGet);
        }
    }
}