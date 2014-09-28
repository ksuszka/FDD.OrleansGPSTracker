using System;

namespace FDD.OrleansGPSTracker.GrainInterfaces
{
    public struct DeviceInfo
    {
        public Guid Id { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public DeviceInfo(Guid id, double latitude, double longitude)
            : this()
        {
            Id = id;
            Latitude = latitude;
            Longitude = longitude;
        }

    }
}