using System; 
namespace AlarmSystem
{
    public class SmokeSensor : IBurntSensor
    {
        public bool IsTriggered { get; set; }
        public double smokeSensorBattery;

        public SmokeSensor(double passedSensorBattery)
        {
            Random rand = new Random();
            int random_int = rand.Next(101);
            if (random_int > 90)
            {
                IsTriggered = true;
            }
            else IsTriggered = false;

            smokeSensorBattery = passedSensorBattery;
        }

        public string GetLocation()
        {
            return "In the auditorium";
        }

        public string GetSensorType()
        {
            return "Smoke Sensor";
        }

        public double GetBatteryPercentage()
        {
            double curr_battery = smokeSensorBattery* 0.8;
            
            return curr_battery;
        }
    }
}
