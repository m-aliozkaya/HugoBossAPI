using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class FactoryProduct:IEntity
    {
        [Key]
        public int Id { get; set; }

        public int FactoryId { get; set; }
        public virtual Factory Factory { get; set; } 

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        public int MaximumCapacity { get; set; }

        public int Capacity { get; set; }
    }
}
