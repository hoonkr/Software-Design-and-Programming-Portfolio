using System;
using System.Collections.Generic;

namespace AlarmSystem
{
    public class ControlUnit : IControlUnit
    {
        public List<double> PollBurntSensors(double smokeSensorBattery, double fireSensorBattery)
        {
            List<IBurntSensor> sensors = new List<IBurntSensor>();
            sensors.Add(Factory.CreateSmokeSensor(smokeSensorBattery));
            sensors.Add(Factory.CreateFireSensor(fireSensorBattery));
            
            
            var batteries = new List<double>();
            
            foreach (IBurntSensor sensor in sensors)
            {
                batteries.Add(sensor.GetBatteryPercentage());
                if (sensor.IsTriggered)
                {
                    Console.WriteLine("A " + sensor.GetSensorType() +  " sensor was triggered at " + sensor.GetLocation() + " with current battery at " + sensor.GetBatteryPercentage());
                }
                else
                {
                    Console.WriteLine("Polled " + sensor.GetSensorType() + " at " + sensor.GetLocation() + " successfully" + " with current battery at " + sensor.GetBatteryPercentage());
                }
            }

            return batteries;
        }
    }

 
}
