using FDD.OrleansGPSTracker.GrainInterfaces;
using Orleans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace FDD.OrleansGPSTracker.DeviceGateway
{
    public class DeviceController : ApiController
    {
        public Guid GetDeviceId([FromUri] string name)
        {
            var filteredName = name.ToLowerInvariant().Trim();
            return new Guid(SHA256Managed.Create().ComputeHash(Encoding.UTF8.GetBytes(filteredName)).Take(16).ToArray());
        }

        public async Task<IList<DeviceInfo>> Get(Guid id, [FromUri]double latitude, [FromUri]double longitude)
        {
            var grainRef = GrainFactory.GetGrain<IDeviceGrain>(id);

            var result = await grainRef.UpdatePositionAndGetSurroundingDevices(latitude, longitude);
            return result;
        }
    }
}