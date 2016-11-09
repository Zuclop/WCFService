using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationMVC.HelpClasses
{
    public class Singleton
    {
        private static Singleton instance;
        private static ServiceReference.ServiceRepositoryOf_GoodsClient repository;
        public static Singleton Instance
        {
            get { return instance ?? (instance = new Singleton()); }
        }

        protected Singleton()
        {
            repository = new ServiceReference.ServiceRepositoryOf_GoodsClient();
        }

        public ServiceReference.ServiceRepositoryOf_GoodsClient Repository
        {
            get { return repository; }
        }
    }
}