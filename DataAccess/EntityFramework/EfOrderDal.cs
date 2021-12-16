using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.EntityFramework
{
    public class EfOrderDal : EfEntityRepositoryBase<Order, Context>, IOrderDal
    {
        public void AddOrderToFactoryOrders(Order order)
        {
            using (var context = new Context())
            {
                var totalAmount = 0;
                var productingFacts = context.FactoryProducts.Where(x => x.ProductId == order.ProductId);
                var capableOfProducing = productingFacts.Where(x => x.Capacity > 0);

                var totalCapacity = capableOfProducing.Sum(x => x.Capacity);
                var totalMaxCapacity = productingFacts.Sum(x => x.MaximumCapacity);

 
                // Ürünler fabrikaların kapasitelerine göre fabrikalara dağıtılır.
                foreach (var item in capableOfProducing)
                {
                    var factoryOrder = new FactoryOrder
                    {
                        // Boş Kapasitelerine oranla sipariş atanır.
                        Amount = (order.Amount > totalCapacity) ? item.Capacity : (int) (order.Amount * (item.Capacity / (float) totalCapacity)),
                        FactoryId = item.FactoryId,
                        OrderId = order.Id
                    };
                    totalAmount += factoryOrder.Amount;
                    item.Capacity -= factoryOrder.Amount;
                    context.FactoryOrders.Add(factoryOrder);
                }


                // Eğer kapasiteleri tam doldurmasana rağmen ürün miktarı duruyorsa
                // ürün kapasitesine göre ürünler fabrikalara dağıtılır.
                if (totalAmount != order.Amount)
                {
                    int amount = order.Amount - totalAmount;
                    foreach (var item in productingFacts)
                    {
                        var factoryOrder = new FactoryOrder
                        {
                            Amount = (int) (amount * ( item.MaximumCapacity / (float) totalMaxCapacity)),
                            FactoryId = item.FactoryId,
                            OrderId = order.Id
                        };
                        totalAmount += factoryOrder.Amount;
                        item.Capacity -= factoryOrder.Amount;
                        context.FactoryOrders.Add(factoryOrder);
                    }
                }



                // Eğer küsüratlı ürün kaldıysa, kalan ürünler kapasitesi en yüksek
                // fabrikaya atanır.
                if (totalAmount != order.Amount)
                {
                    var maxCapacityFactory = productingFacts.OrderByDescending(x => x.MaximumCapacity).FirstOrDefault();
                    var factoryOrder = new FactoryOrder
                    {
                        Amount = order.Amount - totalAmount,
                        FactoryId = maxCapacityFactory.FactoryId,
                        OrderId = order.Id
                    };
                    maxCapacityFactory.Capacity -= factoryOrder.Amount;
                    context.FactoryOrders.Add(factoryOrder);
                }

                context.SaveChanges();

            }
        }
    }
}

