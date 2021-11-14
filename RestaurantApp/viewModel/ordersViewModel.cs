using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantApp.viewModel
{
    public class ordersViewModel
    {
        public int orderId { get; set; }
        public int PaymentTypeId { get; set; }
        public int customerId { get; set; }
        public decimal OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal FinalToal { get; set; }
        public IEnumerable<DetailsViewModel> orderDetailsViewModel { get; set; }
    }
}