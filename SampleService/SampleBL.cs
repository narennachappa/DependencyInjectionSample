using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleInterface;
using SampleEntityModel;

namespace SampleBusinessLayer
{
    public class SampleBL : ISampleBL 
    {
        SampleInterface.Configuration.IDBContextFactory _factory;
        private ISampleDBContext _context;
        private readonly SampleInterface.DataAccessLayer.ISampleDAL _sampleDAL;

        public SampleBL(SampleInterface.Configuration.IDBContextFactory factory, SampleInterface.DataAccessLayer.ISampleDAL sampleDAL)
        {
            _sampleDAL = sampleDAL;
            _factory = factory;
        }

        public void AddData()
        {

            using (_context = _factory.Create())
            {
                _sampleDAL.SetContext(_context);
                _sampleDAL.GetSampleDALMethod();
            }

        }
    }

   
}
