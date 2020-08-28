namespace AlarmSystem
{
    public interface IBurntSensor 
    {
        bool IsTriggered { get; set; }
        string GetLocation();
        string GetSensorType();
        double GetBatteryPercentage();
    }
}