using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.EntityFramework;
using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Interceptors;
using Autofac.Extras.DynamicProxy;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CustomerManager>().As<ICustomerService>().SingleInstance();
            builder.RegisterType<EfCustomerDal>().As<ICustomerDal>().SingleInstance();

            builder.RegisterType<FactoryManager>().As<IFactoryService>().SingleInstance();
            builder.RegisterType<EfFactoryDal>().As<IFactoryDal>().SingleInstance();

            builder.RegisterType<FactoryOrderManager>().As<IFactoryOrderService>().SingleInstance();
            builder.RegisterType<EfFactoryOrderDal>().As<IFactoryOrderDal>().SingleInstance();

            builder.RegisterType<FactoryProductManager>().As<IFactoryProductService>().SingleInstance();
            builder.RegisterType<EfFactoryProductDal>().As<IFactoryProductDal>().SingleInstance();

            builder.RegisterType<OrderManager>().As<IOrderService>().SingleInstance();
            builder.RegisterType<EfOrderDal>().As<IOrderDal>().SingleInstance();

            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();

            builder.RegisterType<SeasonManager>().As<ISeasonService>().SingleInstance();
            builder.RegisterType<EfSeasonDal>().As<ISeasonDal>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
