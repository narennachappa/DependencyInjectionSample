using SampleEntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SampleService
{
    public class SampleDbContextFactory: SampleInterface.Configuration.IDBContextFactory
    {
        public ISampleDBContext Create()
        {
            return new SampleDbContext();
        }
    }
}
