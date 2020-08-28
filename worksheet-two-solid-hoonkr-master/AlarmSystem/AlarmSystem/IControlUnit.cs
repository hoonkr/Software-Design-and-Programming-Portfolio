using System.Collections.Generic;

namespace AlarmSystem
{
    public interface IControlUnit
    {
        List<double> PollBurntSensors(double smokeSensorBattery, double fireSensorBattery);
        
        
    }
}