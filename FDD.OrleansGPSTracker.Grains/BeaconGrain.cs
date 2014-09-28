using FDD.OrleansGPSTracker.GrainInterfaces;
using Orleans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FDD.OrleansGPSTracker.Grains
{
    /// <summary>
    /// Orleans grain implementation class for beacon.
    /// </summary>
    public class BeaconGrain : Grain, IBeaconGrain
    {
        private Dictionary<Guid, DeviceInfo> _devices;

        public async Task UpdateDevicePosition(Guid deviceId, double latitude, double longitude)
        {
            _devices[deviceId] = new DeviceInfo(deviceId, latitude, longitude);
        }

        public async Task Leave(Guid deviceId)
        {
            _devices.Remove(deviceId);
        }

        public async Task<IList<DeviceInfo>> GetDevices()
        {
            return _devices.Values.ToList();
        }

        public override Task ActivateAsync()
        {
            _devices = new Dictionary<Guid, DeviceInfo>();
            return base.ActivateAsync();
        }
    }
}
