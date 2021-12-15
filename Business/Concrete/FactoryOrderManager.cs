using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class FactoryOrderManager : IFactoryOrderService
    {
        IFactoryOrderDal _factoryOrderDal;

        public FactoryOrderManager(IFactoryOrderDal factoryOrderDal)
        {
            _factoryOrderDal = factoryOrderDal;
        }

        public IResult Add(FactoryOrder factoryOrder)
        {
            _factoryOrderDal.Add(factoryOrder);
            return new SuccessResult();
        }

        public IResult Delete(FactoryOrder factoryOrder)
        {
            _factoryOrderDal.Delete(factoryOrder);
            return new SuccessResult();
        }

        public IDataResult<FactoryOrder> GetFactoryOrderById(int id)
        {
            return new SuccessDataResult<FactoryOrder>(_factoryOrderDal.Get(fo => fo.Id == id));
        }

        public IDataResult<List<FactoryOrder>> GetFactoryOrders()
        {
            return new SuccessDataResult<List<FactoryOrder>>(_factoryOrderDal.GetAll());
        }

        public IResult Update(FactoryOrder factoryOrder)
        {
            _factoryOrderDal.Update(factoryOrder);
            return new SuccessResult();
        }
    }
}
