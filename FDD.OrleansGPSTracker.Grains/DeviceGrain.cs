using FDD.OrleansGPSTracker.GrainInterfaces;
using Orleans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FDD.OrleansGPSTracker.Grains
{
    /// <summary>
    /// Orleans grain implementation for device.
    /// </summary>
    public class DeviceGrain : Grain, IDeviceGrain
    {
        private static readonly double latitudeBeaconOffset = 0.01;
        private static readonly double longitudeBeaconOffset = 0.01;

        private IBeaconGrain _currentBeacon;
        private HashSet<IBeaconGrain> _beacons;

        public async Task UpdatePosition(double latitude, double longitude)
        {
            var beacon = BeaconGrainFactory.GetGrain(GetBeaconId(latitude, longitude));
            if (!beacon.Equals(_currentBeacon))
            {
                // different beacon - do a full initialization
                await Cleanup();

                _currentBeacon = beacon;
                _beacons.Clear();
                for (int i = -1; i <= 1; i++)
                {
                    for (int j = -1; j <= 1; j++)
                    {
                        _beacons.Add(
                            BeaconGrainFactory.GetGrain(GetBeaconId(latitude + i*latitudeBeaconOffset,
                                longitude + j*longitudeBeaconOffset)));
                    }
                }
            }

            await _currentBeacon.UpdateDevicePosition(this.GetPrimaryKey(), latitude, longitude);
        }

        public async Task<IEnumerable<DeviceInfo>> GetSurroundingDevices()
        {
            var infos = await Task.WhenAll(_beacons.Select(b => b.GetDevices()));
            return infos.SelectMany(x => x).ToList();
        }

        public async Task<IList<DeviceInfo>> UpdatePositionAndGetSurroundingDevices(double latitude, double longitude)
        {
            await UpdatePosition(latitude, longitude);
            return (await GetSurroundingDevices()).ToList();
        }

        public override Task ActivateAsync()
        {
            _beacons = new HashSet<IBeaconGrain>();
            return base.ActivateAsync();
        }

        public override async Task DeactivateAsync()
        {
            await Cleanup();
            await base.DeactivateAsync();
        }

        private async Task Cleanup()
        {
            if (_currentBeacon != null)
            {
                await _currentBeacon.Leave(this.GetPrimaryKey());
            }
        }

        static private Guid GetBeaconId(double latitude, double longitude)
        {
            // c.a. 1km
            var lat = Convert.ToInt32(Math.Round(latitude / latitudeBeaconOffset));
            var lon = Convert.ToInt32(Math.Round(longitude / longitudeBeaconOffset));

            var bytes = new byte[] {0, 0, 0, 0, 0, 0, 0, 0, 0xaa, 0xbb, 0xaa, 0xbb, 0xaa, 0xbb, 0xaa, 0xbb};
            BitConverter.GetBytes(lat).CopyTo(bytes, 0);
            BitConverter.GetBytes(lon).CopyTo(bytes, 4);
            return new Guid(bytes);
        }
    }
}
