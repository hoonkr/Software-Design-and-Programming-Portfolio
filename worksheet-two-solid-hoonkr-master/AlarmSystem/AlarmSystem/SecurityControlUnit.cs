using System;
using System.Collections.Generic;

namespace AlarmSystem
{
    public class SecurityControlUnit : ISecurityControlUnit
    {
        public void PollSecuritySensors()
        {
            List<ISensor> sensors = new List<ISensor>();
            sensors.Add(Factory.CreateMotionSensor());
            sensors.Add(Factory.CreateHeatSensor());

            foreach (ISensor sensor in sensors)
            {
                if (sensor.IsTriggered)
                {
                    Console.WriteLine("A " + sensor.GetSensorType() +  " sensor was triggered at " + sensor.GetLocation());
                }
                else
                {
                    Console.WriteLine("Polled " + sensor.GetSensorType() + " at " + sensor.GetLocation() + " successfully");
                }
            }
        }
        
    }
}