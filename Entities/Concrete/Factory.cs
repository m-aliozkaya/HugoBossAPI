using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class Factory
    {
        [Key]

        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public ICollection<FactoryProduct> FactoryProducts { get; set; }
        public ICollection<FactoryOrder> FactoryOrders { get; set; }
    }
}
