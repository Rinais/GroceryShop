using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantApp.viewModel
{
    public class DetailsViewModel
    {
        public int orderId { get; set; }
        public int OrderDetailId { get; set; }
        public int ItemId { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
        public decimal quantity { get; set; }
    }
}