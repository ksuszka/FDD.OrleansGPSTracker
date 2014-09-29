using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Security;
using System.Web.SessionState;
using FDD.OrleansGPSTracker.DeviceGateway;

namespace FDD.OrleansGPSTracker.DeviceWebEmulator
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            FDD.OrleansGPSTracker.DeviceGateway.Global.Initialize();
        }
    }
}