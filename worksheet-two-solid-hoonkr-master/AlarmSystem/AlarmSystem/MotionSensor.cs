namespace AlarmSystem
{
    public class MotionSensor : ISensor
    {
        public bool IsTriggered { get; set; }

        public MotionSensor()
        {
            
        }
        public string GetLocation()
        {
            return "2nd Floor office";
        }

        public string GetSensorType()
        {
            return "Motion Sensor";
        }
        
    }
}