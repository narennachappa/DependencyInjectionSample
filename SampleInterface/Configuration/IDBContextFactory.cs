using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleEntityModel;

namespace SampleInterface.Configuration
{
    public interface IDBContextFactory
    {
        ISampleDBContext Create();
    }
}
