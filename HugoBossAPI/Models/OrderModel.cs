using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HugoBossAPI.Models
{
    public class OrderModel
    {
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public int Priority { get; set; }
        public int Amount { get; set; }
        public DateTime DeliveryDate { get; set; }
    }
}
