using System;

namespace mediator
{
    public class Button : IColleague
    {
        public IMachineMediator Mediator { get; set; }

        public void Press()
        {
            Console.WriteLine("Button pressed.");
            Mediator.Start();
            Mediator.Closed();
            Mediator.On();
            Mediator.Off();
            Mediator.Wash();
        }
    }
}