using System;

namespace Bridge
{
    public class GearLocking : IProduct
    {
        public GearLocking(string name)
        {
            ProductName = name;
        }

        public string ProductName { get; set; }

        public void Produce()
        {
            Console.WriteLine("Gear Locking");
        }

        public override string ToString()
        {
            return base.ToString(); // REPLACE
        }
    }
}