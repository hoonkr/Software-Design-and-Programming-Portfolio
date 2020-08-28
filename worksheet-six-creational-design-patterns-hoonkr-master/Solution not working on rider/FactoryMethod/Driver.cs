using System;

namespace QuestionThree
{
    public static class Driver
    {
        public static void Main(string[] args)
        {
            VehicleFactory factory = new ConcreteVehicleFactory();

            IProduct scooter = factory.GetVehicle("Scooter");
            scooter.Drive(10);

            IProduct bike = factory.GetVehicle("Bike");
            bike.Drive(10);
            
        }
    }
}