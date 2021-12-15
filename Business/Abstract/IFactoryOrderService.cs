using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IFactoryOrderService
    {
        IDataResult<List<FactoryOrder>> GetFactoryOrders();
        IResult Add(FactoryOrder factoryOrder);
        IResult Delete(FactoryOrder factoryOrder);
        IResult Update(FactoryOrder factoryOrder);
        IDataResult<FactoryOrder> GetFactoryOrderById(int id);
    }
}
