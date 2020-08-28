using System;

namespace Facade
{
    public class ScheduleServerImpl: IScheduleServer
    {
        public void StartBooting()
        {
            Console.WriteLine("Booting...");
        }

        public void ReadSystemConfigFile()
        {
            Console.WriteLine("Reading System Config file...");
        }

        public void InitializeContext()
        {
            Console.WriteLine("Initializing context...");
        }

        public void InitializeListeners()
        {
            Console.WriteLine("Initializing Listeners...");
        }

        public void CreateSystemObjects()
        {
            Console.WriteLine("Creating system objects...");
        }

        public void ReleaseProcesses()
        {
            Console.WriteLine("Releasing processes...");
        }

        public void Destroy()
        {
            Console.WriteLine("Destroying...");
        }

        public void DestroySystemObjects()
        {
            Console.WriteLine("Destroying system objects...");
        }

        public void DestroyListeners()
        {
            Console.WriteLine("Destroying listeners...");
        }

        public void DestroyContext()
        {
            Console.WriteLine("Destroying context...");
        }

        public void Shutdown()
        {
            Console.WriteLine("Shutting down...");
        }
    }
}