using Core.Utilities.Results;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IFactoryService 
    {
        IDataResult<List<Factory>> GetFactories();
        IResult Add(Factory factory);
        IResult Delete(Factory factory);
        IResult Update(Factory factory);
        IDataResult<Factory> GetFactoryById(int id);

    }
}
