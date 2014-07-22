using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRDemo.Models
{
    public class CartItem
    {
        public Product Product { get; set; }

        public int Quantity { get; set; }

        public decimal Cost
        {
            get
            {
                return Quantity * Product.UnitPrice;
            }
        }
    }
}