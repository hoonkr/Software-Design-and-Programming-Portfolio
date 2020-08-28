using System;
namespace AlarmSystem
{
    public class FireSensor :IBurntSensor
    {
        public bool IsTriggered { get; set; }
        private double fireSensorBattery;

        public FireSensor(double passedSensorBattery)
        {
            Random rand = new Random();
            int rand_int = rand.Next(101);
            if (rand_int > 95)
            {
                IsTriggered = true;
            }
            else IsTriggered = false;

            fireSensorBattery = passedSensorBattery;
        }
        
        public string GetLocation()
        {
            return "Lobby 1st floor";
        }

        public string GetSensorType()
        {
            return "Fire Sensor";
        }

        public double GetBatteryPercentage()
        {
            
            double curr_battery = fireSensorBattery*0.9; 
            return curr_battery;
        }
    }
}
