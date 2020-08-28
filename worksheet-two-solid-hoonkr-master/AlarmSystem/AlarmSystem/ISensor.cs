using System;
namespace AlarmSystem
{
    interface ISensor
    {
        public bool IsTriggered { get; set; }
        public string GetLocation();
        public string GetSensorType();
    }
}
