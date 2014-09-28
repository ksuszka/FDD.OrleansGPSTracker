using Microsoft.WindowsAzure.ServiceRuntime;
using Orleans.Host;
using System.Diagnostics;
using System.Net;

namespace FDD.OrleansGPSTracker.OrleansSilo
{
    public class WorkerRole : RoleEntryPoint
    {
        private OrleansAzureSilo orleansAzureSilo;

        public override void Run()
        {
            Trace.TraceInformation("FDD.OrleansGPSTracker.OrleansSilo is running");
            orleansAzureSilo.Run(); // Call will block until silo is shutdown
        }

        public override bool OnStart()
        {
            // Set the maximum number of concurrent connections
            ServicePointManager.DefaultConnectionLimit = 12;

            // For information on handling configuration changes
            // see the MSDN topic at http://go.microsoft.com/fwlink/?LinkId=166357.

            orleansAzureSilo = new OrleansAzureSilo();

            bool result = base.OnStart();

            if (result)
            {
                result = orleansAzureSilo.Start(RoleEnvironment.DeploymentId, RoleEnvironment.CurrentRoleInstance);
            }

            Trace.TraceInformation("FDD.OrleansGPSTracker.OrleansSilo has been started (result={0})", result);

            return result;
        }

        public override void OnStop()
        {
            Trace.TraceInformation("FDD.OrleansGPSTracker.OrleansSilo is stopping");

            orleansAzureSilo.Stop();

            base.OnStop();

            Trace.TraceInformation("FDD.OrleansGPSTracker.OrleansSilo has stopped");
        }
    }
}
