using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SampleInterface;
using DAL;
using Ninject.Modules;
using SampleBusinessLayer;
using SampleService;

namespace SampleWeb
{
    public class NinjectBindings : NinjectModule
    {
        public override void Load()
        {
            // Bind (Declares a binding for the specified service)

            // Here We are Binding services to Inject 
            // In this we will inject DL using Interface Iproduct
            Bind<SampleInterface.Configuration.IDBContextFactory>().To<SampleDbContextFactory>();
            Bind<SampleInterface.DataAccessLayer.ISampleDAL>().To<DAL.SampleDAL>();

            Bind<ISampleBL>().To<SampleBL>();
        }
    }
}