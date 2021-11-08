using RestaurantApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantApp.Repositories
{
    public class paymentTypeRepository
    {
        private RestaurantDBEntities1 restaurant;
        public paymentTypeRepository()
        {
            restaurant = new RestaurantDBEntities1();
        }

        public IEnumerable<SelectListItem> getAllPayments()
        {
            IEnumerable<SelectListItem> selectedItems = new List<SelectListItem>();
            selectedItems = (from obj in restaurant.items
                             select new SelectListItem()
                             {
                                 Text = obj.itemName,
                                 Value = obj.itemId.ToString(),
                                 Selected = true
                             }).ToList();
            return selectedItems;
        }
    }
}