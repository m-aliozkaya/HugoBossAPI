using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HugoBossAPI.Models
{
    public class FactoryDetailModel
    {
        public string Name { get; set; }
        public List<FactoryProduct> FactoryProducts { get; set; }
    }
}
