using RestaurantApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantApp.Repositories
{
    public class customerRepository
    {
        private RestaurantDBEntities1 restaurant;
        public customerRepository()
        {
            restaurant = new RestaurantDBEntities1();
        }

        public IEnumerable<SelectListItem> getAllCustomers()
        {
            IEnumerable<SelectListItem> selectAllItems = new List<SelectListItem>();

            selectAllItems = (from obj in restaurant.Customers
                              select new SelectListItem()
                              {
                                  Text = obj.customerName,
                                  Value = obj.customerId.ToString(),
                                  Selected = true
                              }).ToList();
            return selectAllItems;
        }

    }
}