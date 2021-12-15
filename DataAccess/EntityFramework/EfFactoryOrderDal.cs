using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EntityFramework
{
    public class EfFactoryOrderDal : EfEntityRepositoryBase<FactoryOrder,Context> , IFactoryOrderDal
    {
    }
}
