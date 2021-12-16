using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HugoBossAPI.Models
{
    public class ProductDetailModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Season season { get; set; }
    }
}
