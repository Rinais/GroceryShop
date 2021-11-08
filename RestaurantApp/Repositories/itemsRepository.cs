using RestaurantApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantApp.Repositories
{
    public class itemsRepository
    {
        private RestaurantDBEntities1 restaurant;
        public itemsRepository()
        {
            restaurant = new RestaurantDBEntities1();
        }

        public IEnumerable<SelectListItem> getAllItems()
        {
            IEnumerable<SelectListItem> allItems = new List<SelectListItem>();
            allItems = (from obj in restaurant.items
                        select new SelectListItem()
                        {
                            Text = obj.itemName,
                            Value = obj.itemId.ToString(),
                            Selected = true
                        }).ToList();
            return allItems;
        }
    }
}