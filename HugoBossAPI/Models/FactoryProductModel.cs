using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HugoBossAPI.Models
{
    public class FactoryProductModel
    {
        public int FactoryId { get; set; }
        public int ProductId { get; set; }
        public int MaximumCapacity { get; set; }
        public int Capacity { get; set; }
    }
}
