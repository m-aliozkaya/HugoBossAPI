using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class Product
    {
        [Key]

        public int Id { get; set; }

        public int SeasonId { get; set; }
        public virtual Season Season { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public ICollection<FactoryProduct> FactoryProducts { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
