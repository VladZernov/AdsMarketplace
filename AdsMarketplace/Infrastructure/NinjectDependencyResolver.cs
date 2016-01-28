using System;
using System.Collections.Generic;
using System.Configuration;
using System.Web.Mvc;
using Moq;
using Ninject;
using AdsMarketplace.Domain.Abstract;
using AdsMarketplace.Domain.Entities;
using AdsMarketplace.Domain.Concrete;


namespace AdsMarketplace.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            //Привязка указывает Ninject о том, что для обслуживания запросов к интерфейсу IAdvertisementRepository 
            //необходимо создавать экземпляры класса EFAdvertisementRepository
            kernel.Bind<IAdvertisementRepository>().To<EFAdvertisementRepository>();
        }
    }
}