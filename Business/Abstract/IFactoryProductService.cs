using Core.Utilities.Results;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IFactoryProductService
    {
        IDataResult<List<FactoryProduct>> GetFactoryProducts();
        IResult Add(FactoryProduct factoryProduct);
        IResult Delete(FactoryProduct factoryProduct);
        IResult Update(FactoryProduct factoryProduct);
        IDataResult<FactoryProduct> GetFactoryProductById(int id);
    }
}
