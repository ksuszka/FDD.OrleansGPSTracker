using Orleans;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FDD.OrleansGPSTracker.GrainInterfaces
{
    /// <summary>
    /// Orleans grain communication interface for device grain.
    /// </summary>
    public interface IDeviceGrain : IGrainWithGuidKey
    {
        Task UpdatePosition(double latitude, double longitude);
        Task<IEnumerable<DeviceInfo>> GetSurroundingDevices();

        Task<IList<DeviceInfo>> UpdatePositionAndGetSurroundingDevices(double latitude, double longitude);
    }
}
