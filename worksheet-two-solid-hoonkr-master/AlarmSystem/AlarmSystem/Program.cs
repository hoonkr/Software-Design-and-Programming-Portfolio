using System;

namespace AlarmSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            IControlUnit controlUnit = Factory.CreateControlUnit();
            ISecurityControlUnit securityControlUnit = Factory.CreateSecurityControlUnit();
            
            double smokeSensorBattery = 100;
            double fireSensorBattery = 100;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "exit")
                {
                    break;
                }
                Console.WriteLine("Type \"poll\" to poll all sensors once or \"exit\" to exit");
                if (input.Equals("poll"))
                {
                    var batteries = controlUnit.PollBurntSensors(smokeSensorBattery, fireSensorBattery);
                    
                    smokeSensorBattery = batteries[0];
                    fireSensorBattery = batteries[1];

                    TimeSpan start = TimeSpan.Parse("22:00");
                    TimeSpan end = TimeSpan.Parse("06:00");
                    TimeSpan now = DateTime.Now.TimeOfDay;
                    
                    
                    if (now >= start || now <= end)
                    {
                        securityControlUnit.PollSecuritySensors(); 
                    }
                    

                }
                
            }
        }
    }
}
