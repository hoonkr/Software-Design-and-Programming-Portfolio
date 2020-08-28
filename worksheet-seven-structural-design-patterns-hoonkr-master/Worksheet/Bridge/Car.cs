using System;
using System.Net.Http.Headers;

namespace Bridge
{
    public abstract class Car
    {
        private IProduct product;
        private string carType;
        public Car(IProduct product, string carType)
        {
            this.product = product;
            this.carType = carType;
        }
        
        public abstract void Assemble();
        public abstract void ProduceProduct();
        public abstract void Modify();
        
        public void printDetails(){Console.WriteLine("Car: "+ carType + ", Product:"+ product.ProductName);}
        
        
        

        public override string ToString()
        {
            return base.ToString(); // REPLACE
        }
    }
}