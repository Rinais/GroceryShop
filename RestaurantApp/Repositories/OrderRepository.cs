using RestaurantApp.Models;
using RestaurantApp.viewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantApp.Repositories
{
    public class OrderRepository
    {
        private RestaurantDBEntities1 restaurant;
        public OrderRepository()
        {
            restaurant = new RestaurantDBEntities1();
        }
        public Boolean AddItems(ordersViewModel orderViewModel)
        {
            order order = new order();

            order.customerId= orderViewModel.customerId;
            order.orderNumber=String.Format("{0: ddmmyyyyhhmmss}",DateTime.Now);
            order.orderDate=DateTime.Now;
            order.paymentTypeId = orderViewModel.PaymentTypeId;
            order.finalTotal = orderViewModel.FinalToal;
            restaurant.orders.Add(order);
            restaurant.SaveChanges();
            int orderId = order.orderId;

            foreach (var items in orderViewModel.orderDetailsViewModel)
            {
                Detail detail = new Detail();
                detail.orderId = orderId;
                detail.itemsId = items.ItemId;
                detail.UnitPrice = items.UnitPrice;
                detail.Discount = items.Discount;
                detail.FinalTotal = items.Total;
                detail.Quantity = items.quantity;

                restaurant.Details.Add(detail);
                restaurant.SaveChanges();

                transaction transaction = new transaction();
                transaction.itemId = items.ItemId;
                transaction.quantity = (-1) * items.quantity;
                transaction.typeId = 2;
                transaction.transactionDate = DateTime.Now;

                restaurant.transactions.Add(transaction);
                restaurant.SaveChanges();
            }

            return true;
        }
    }
}