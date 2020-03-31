using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleInterface;
using SampleInterface.DataAccessLayer;
using SampleEntityModel;


namespace DAL
{
    public class SampleDAL : SampleInterface.DataAccessLayer.ISampleDAL
    {

        private ISampleDBContext dbContext;

        public void SetContext(ISampleDBContext context)
        {
            dbContext = context;
        }

        void ISampleDAL.GetSampleDALMethod()
        {
            //throw new NotImplementedException();
            string s = "Success";
        }
    }
}
