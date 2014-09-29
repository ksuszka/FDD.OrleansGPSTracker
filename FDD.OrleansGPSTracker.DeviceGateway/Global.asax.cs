using Orleans.Host;
using System;
using System.IO;
using System.Web.Http;

namespace FDD.OrleansGPSTracker.DeviceGateway
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Initialize();
        }

        public static void Initialize()
        {
            GlobalConfiguration.Configure(config =>
            {
                config.MapHttpAttributeRoutes();

                config.Routes.MapHttpRoute(
                    name: "DefaultApi",
                    routeTemplate: "api/{controller}/{id}",
                    defaults: new { id = RouteParameter.Optional }
                );
            });

            InitializeOrleans();
        }

        private static void InitializeOrleans()
        {
            if (!OrleansAzureClient.IsInitialized)
            {
                FileInfo clientConfigFile = AzureConfigUtils.ClientConfigFileLocation;
                if (!clientConfigFile.Exists)
                {
                    throw new FileNotFoundException(string.Format("Cannot find Orleans client config file for initialization at {0}", clientConfigFile.FullName), clientConfigFile.FullName);
                }
                OrleansAzureClient.Initialize(clientConfigFile);
            }
        }
    }
}