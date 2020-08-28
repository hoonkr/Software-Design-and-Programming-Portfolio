using System;

namespace mediator
{
    public class Valve : IColleague
    {
        public IMachineMediator Mediator { get; set; }
        public void Open() => Console.WriteLine("Valve is opened...\nfilling water...");
        public void Closed() => Console.WriteLine("Valve is closed...");
    }
}