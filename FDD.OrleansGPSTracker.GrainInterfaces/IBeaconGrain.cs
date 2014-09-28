using Orleans;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FDD.OrleansGPSTracker.GrainInterfaces
{
    /// <summary>
    /// Orleans grain communication interface for beacon grain.
    /// </summary>
    public interface IBeaconGrain : IGrainWithGuidKey
    {
        Task UpdateDevicePosition(Guid deviceId, double latitude, double longitude);
        Task Leave(Guid deviceId);
        Task<IList<DeviceInfo>> GetDevices();
    }
}
