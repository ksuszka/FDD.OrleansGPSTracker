using FDD.OrleansGPSTracker.GrainInterfaces;
using NUnit.Framework;
using Orleans.Samples.Testing;
using System;
using System.Linq;

namespace FDD.OrleansGPSTracker.Grains.Tests
{
    public class DeviceGrainTests
    {
        private static readonly UnitTestSiloOptions siloOptions = new UnitTestSiloOptions
        {
            StartFreshOrleans = true
        };
        private static readonly UnitTestClientOptions clientOptions = new UnitTestClientOptions
        {
            ResponseTimeout = TimeSpan.FromSeconds(30)
        };

        private static UnitTestSiloHost unitTestSiloHost;

        private Guid _deviceId = Guid.Parse("12345678-1234-1234-1234-1234567890ab");

        [TestFixtureSetUp]
        public void SetUpFixture()
        {
            AppDomain.CurrentDomain.ClearShadowCopyPath();
            unitTestSiloHost = new UnitTestSiloHost(siloOptions, clientOptions);

            Assert.AreEqual(2, unitTestSiloHost.GetActiveSilos().Count(), "Silo count at start of tests");

        }

        [TestFixtureTearDown]
        public void TearDownFixture()
        {
            if (unitTestSiloHost != null)
            {
                try
                {
                    unitTestSiloHost.StopDefaultSilos();
                }
                catch (Exception exc) { Console.WriteLine(exc); }
            }
            unitTestSiloHost = null;

        }

        [Test]
        public async void UpdateShouldReturnSameDevice()
        {
            //given
            var device = DeviceGrainFactory.GetGrain(_deviceId);

            //when
            var result = await device.UpdatePositionAndGetSurroundingDevices(30, 40);

            //then
            Assert.That(result.Any(d => AreEqual(d.Latitude, 30) && AreEqual(d.Longitude, 40)));
        }

        [Test]
        public async void UpdateShouldReturnNearDevice()
        {
            //given
            var device1 = DeviceGrainFactory.GetGrain(_deviceId);
            var device2 = DeviceGrainFactory.GetGrain(Guid.NewGuid());

            //when
            await device2.UpdatePosition(30, 40);
            var result = await device1.UpdatePositionAndGetSurroundingDevices(30.0001, 40);

            //then
            Assert.That(result.Any(d => AreEqual(d.Latitude, 30) && AreEqual(d.Longitude, 40)));
        }

        private static bool AreEqual(double a, double b)
        {
            return Math.Abs(a - b) < 0.0000001;
        }
    }
}
