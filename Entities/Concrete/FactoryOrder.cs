using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class FactoryOrder
    {
        [Key]

        public int Id { get; set; }

        public int OrderId { get; set; }
        public virtual Order Order { get; set; }

        public int FactoryId { get; set; }
        public virtual Factory Factory { get; set; }

        public bool Status { get; set; }

        public int Amount { get; set; }
    }
}
