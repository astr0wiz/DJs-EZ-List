using EZList.Domain.Abstract;
using EZList.Domain.Core;
using Moq;
using Ninject;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EZList.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel refdKernel)
        {
            kernel = refdKernel;
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
            Mock<IDJListRepository> mock = new Mock<IDJListRepository>();
            mock.Setup(m => m.DJLists).Returns(new List<DJList>
            {
                new DJList
                {
                    ListId = 1,
                    ListName = "Groceries",
                    Description = "Food and everything from the grocery store"
                },
                new DJList {ListId = 2, ListName = "School", Description = "School Papers due this semester"},
                new DJList {ListId = 3, ListName = "Birthdays", Description = "All the birthdays this year"}
            });
            kernel.Bind<IDJListRepository>().ToConstant(mock.Object);
        }
    }
}