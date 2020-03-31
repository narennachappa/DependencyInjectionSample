using SampleInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleWeb
{
    public class SampleInitialLoad
    {
        ISampleBL _sampleBL;
        public SampleInitialLoad(ISampleBL sampleBL)
        {
            _sampleBL = sampleBL;
        }
    }
}