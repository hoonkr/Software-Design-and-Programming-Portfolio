namespace AlarmSystem
{
    public class HeatSensor:ISensor
    {
        public bool IsTriggered { get; set; }
        public string GetLocation()
        {
           return "Ground Floor Entrance";
        }

        public string GetSensorType()
        {
           return "Heat Sensor";
        }
    }
}