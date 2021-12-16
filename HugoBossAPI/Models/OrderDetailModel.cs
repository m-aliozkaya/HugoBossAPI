using Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HugoBossAPI.Models
{
    public class OrderDetailModel
    {
        public int Priority { get; set; }
        public int Amount { get; set; }
        public DateTime DeliveryDate { get; set; }
        public Product product { get; set; }
        public Customer customer { get; set; }
    }
}
