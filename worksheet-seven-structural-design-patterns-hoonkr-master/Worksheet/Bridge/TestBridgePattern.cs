using System;

namespace Bridge
{
    public static class TestBridgePattern
    {
        public static void Main(string[] args)
        {
            IProduct product = new CentralLocking("Central Locking System");
            IProduct product2 = new GearLocking("Gear Locking System");
            Car car = new BigWheel(product, "BigWheel xz model");
            car.ProduceProduct();
            car.Modify();
            car.Assemble();
            car.printDetails();
            
            Console.WriteLine();

            car = new BigWheel(product2, "BigWheel xz model");
            car.ProduceProduct();
            car.Modify();
            car.Assemble();
            car.printDetails();
            
            Console.WriteLine();

            Console.WriteLine("-----------------------------------------------------");

            car = new Motoren(product, "Motoren lm model");
            car.ProduceProduct();
            car.Modify();
            car.Assemble();
            car.printDetails();
            
            Console.WriteLine();

            car = new Motoren(product2, "Motoren lm model");
            car.ProduceProduct();
            car.Modify();
            car.Assemble();
            car.printDetails();
            
            Console.WriteLine();
        }
    }
}