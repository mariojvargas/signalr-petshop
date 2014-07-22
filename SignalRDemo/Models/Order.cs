using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SignalRDemo.Models
{
    public class Order
    {
        public Guid Id { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }

        public DateTime OrderDate { get; set; }
    }
}
