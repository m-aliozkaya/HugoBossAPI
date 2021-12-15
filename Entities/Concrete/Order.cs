using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class Order: IEntity
    {
        [Key]

        public int Id { get; set; }

        public int Priority { get; set; }

        public bool Status { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get;set; }

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public int Amount { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime DeliveryDate { get; set; }

        public ICollection<FactoryOrder> FactoryOrders { get; set; }
    }
}
