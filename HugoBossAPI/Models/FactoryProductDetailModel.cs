using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HugoBossAPI.Models
{
    public class FactoryProductDetailModel
    {
        public int MaximumCapacity { get; set; }
        public int Capacity { get; set; }
        public Product product { get; set; }
        public Factory factory { get; set; }
    }
}
