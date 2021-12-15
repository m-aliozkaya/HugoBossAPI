using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class Customer
    {
        [Key]

        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
