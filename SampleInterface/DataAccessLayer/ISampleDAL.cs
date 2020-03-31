using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleEntityModel;

namespace SampleInterface.DataAccessLayer
{
    public interface ISampleDAL
    {
        void SetContext(ISampleDBContext context);
        void GetSampleDALMethod();

    }
}
