using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AlarmSystem.Tests
{
    [TestClass]
    public class FireSensorTest
    {
        [TestMethod]
        public void TestThatIsTriggeredReturnsFalse()
        {
            FireSensor sensor = new FireSensor(100);
            bool isTriggered = sensor.IsTriggered;
            Assert.AreEqual(false, isTriggered);
        }

        [TestMethod]
        public void TestThatGetLocationReturnsNull()
        {
            FireSensor sensor = new FireSensor(100);
            string location = sensor.GetLocation();
            Console.WriteLine(location);
            Assert.AreEqual(String.Empty, location);
        }

        [TestMethod]
        public void TestThatGetSensorTypeReturnsNull()
        {
            FireSensor sensor = new FireSensor(100);
            string sensorType = sensor.GetSensorType();
            Assert.AreEqual(String.Empty, sensorType);
        }

        [TestMethod]
        public void TestThatGetBatteryPercentageReturnsNegativeOne()
        {
            FireSensor sensor = new FireSensor(100);
            double batteryPercentage = sensor.GetBatteryPercentage();
            Assert.AreEqual(-1.0, batteryPercentage);
        }
    }
}
