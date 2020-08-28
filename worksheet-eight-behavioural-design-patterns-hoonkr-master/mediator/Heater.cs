using System;

namespace mediator
{
    public class Heater : IColleague
    {
        public IMachineMediator Mediator { get; set; }

        public void On(int temp) => Console.WriteLine("Heater is on...\nTemperature reached "+temp +" C\nTemperature is set to "+temp+" C");
        public void Off() => Console.WriteLine("Heater is off...");
    }
}