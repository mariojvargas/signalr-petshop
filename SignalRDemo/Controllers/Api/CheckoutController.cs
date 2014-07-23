using Microsoft.AspNet.SignalR;
using SignalRDemo.Hubs;
using SignalRDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace IntroToKnockoutJs.Controllers
{
    public class CheckoutController : ApiController
    {
        //
        // POST: /Checkout/

        public IHttpActionResult Post(CartItem[] cartItems)
        {
            // NOTE: I am naively accepting whatever the client sent to the server and processing it.
            //       In a real world situation, you would only take the SKU and quantity and match this
            //       against the data source. As extra security, the prices could be verified to ensure
            //       data wasn't tampered with.

            var itemTotal = cartItems.Sum(c => c.Quantity);
            var orderTotal = cartItems.Sum(c => c.Cost);

            Order orderInfo = CreateNewOrder(cartItems);

            string response = String.Format("Thank you for ordering {0} amazing pets. Your total is {1:C}. Your order ID is {2}",
                itemTotal,
                orderTotal,
                orderInfo.Id);

            NotifyProcessingDepartment(orderInfo);

            return Ok(response);
        }

        private Order CreateNewOrder(IEnumerable<CartItem> cartItems)
        {
            return new Order()
            {
                Id = Guid.NewGuid(),
                OrderDetails = CreateOrderDetails(cartItems),
                OrderDate = DateTime.UtcNow
            };
        }

        private ICollection<OrderDetail> CreateOrderDetails(IEnumerable<CartItem> cartItems)
        {
            return cartItems.Select(item => new OrderDetail()
            {
                Product = item.Product,
                Quantity = item.Quantity
            }).ToList();
        }

        private void NotifyProcessingDepartment(Order order)
        {
            // Get instance of current OrderProcessHub
            var hub = GlobalHost.ConnectionManager.GetHubContext<OrderProcessHub>();

            // Execute "pushOrder" client script function
            hub.Clients.Group(PetShopGroups.ProcessingDepartment).pushOrder(order);
        }
    }
}
