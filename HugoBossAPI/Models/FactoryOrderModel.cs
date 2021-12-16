using Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HugoBossAPI.Models
{
    public class FactoryOrderModel
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public int Amount { get; set; }
        public Order order { get; set; }
        public Factory factory { get; set; }
    }
}
