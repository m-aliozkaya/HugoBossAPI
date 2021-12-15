using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product,Context> , IProductDal
    {
    }
}
