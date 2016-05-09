using Domain.Abstract;
using Domain.Concrete;
using Domain.Entities;
using Moq;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Infrastructure
{
    class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }
        private void AddBindings()
        {
            ////is located links(first link shold be replace to real link to DB)
            //mock<ibookrepository> mock = new mock<ibookrepository>();
            //mock.setup(m => m.books).returns(new list<book>
            //{
            //    new book {name = "book 1", author = "author_1", price = 1000 },
            //    new book {name = "book 2", author = "author_2", price = 2000 },
            //    new book {name = "book 3", author = "author_3", price = 3000 }
            //});
            //link to real DB
            kernel.Bind<IBookRepository>().To<EFBookRepository>();
        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
    }
}
