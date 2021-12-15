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
    public class FactoryManager : IFactoryService
    {
        IFactoryDal _factoryDal;

        public FactoryManager(IFactoryDal factoryDal)
        {
            _factoryDal = factoryDal;
        }

        public IResult Add(Factory factory)
        {
            _factoryDal.Add(factory);
            return new SuccessResult();
        }

        public IResult Delete(Factory factory)
        {
            _factoryDal.Delete(factory);
            return new SuccessResult();
        }

        public IDataResult<List<Factory>> GetFactories()
        {
            return new SuccessDataResult<List<Factory>>(_factoryDal.GetAll());
        }

        public IDataResult<Factory> GetFactoryById(int id)
        {
            return new SuccessDataResult<Factory>(_factoryDal.Get(f => f.Id == id));
        }

        public IResult Update(Factory factory)
        {
            _factoryDal.Update(factory);
            return new SuccessResult();
        }
    }
}
