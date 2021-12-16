using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class FactoryProductManager : IFactoryProductService
    {
        IFactoryProductDal _factoryProductDal;

        public FactoryProductManager(IFactoryProductDal factoryProductDal)
        {
            _factoryProductDal = factoryProductDal;
        }

        public IResult Add(FactoryProduct factoryProduct)
        {
            _factoryProductDal.Add(factoryProduct);
            return new SuccessResult();
        }

        public IResult Delete(FactoryProduct factoryProduct)
        {
            _factoryProductDal.Delete(factoryProduct);
            return new SuccessResult();
        }

        public IDataResult<FactoryProduct> GetFactoryProductById(int id)
        {
            return new SuccessDataResult<FactoryProduct>(_factoryProductDal.Get(fp => fp.Id == id));
        }

        public IDataResult<List<FactoryProduct>> GetFactoryProducts()
        {
            return new SuccessDataResult<List<FactoryProduct>>(_factoryProductDal.GetAll());
        }

        public IDataResult<List<FactoryProduct>> GetFactoryProductsByFactoryId(int id)
        {
            return new SuccessDataResult<List<FactoryProduct>>(_factoryProductDal.GetAll(x => x.FactoryId == id));
        }

        public IResult Update(FactoryProduct factoryProduct)
        {
            _factoryProductDal.Update(factoryProduct);
            return new SuccessResult();
        }
    }
}
