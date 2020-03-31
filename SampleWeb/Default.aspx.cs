using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ninject;
using System.Reflection;
using SampleInterface;


namespace SampleWeb
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Initializes a new instance of the Ninject.StandardKernel class.
            StandardKernel _Kernal = new StandardKernel();
            //load Modules
            _Kernal.Load(Assembly.GetExecutingAssembly());
            //Gets an instance of the specified service. 
            // In this step Ninject will inject DL object to BL 
            ISampleBL _sampleBL = _Kernal.Get<ISampleBL>();
            _sampleBL.AddData();

        }

        
    }
}