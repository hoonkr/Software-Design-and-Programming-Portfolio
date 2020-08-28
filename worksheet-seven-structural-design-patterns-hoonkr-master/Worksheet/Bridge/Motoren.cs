using System;

namespace Bridge
{
    public class Motoren : Car
    {
        private IProduct _product;
        private string _v;
        public Motoren(IProduct product, string v) : base(product, v)
        {
            _product = product;
            _v = v;
        }

        public override void Assemble()
        {
           Console.WriteLine("Producing"+ " "+_product.ProductName);
        }

        public override void ProduceProduct()
        {
            Console.WriteLine("Assembling"+ " " +_product.ProductName+" for "+ _v );
        }
        
        public override void Modify()
        {
            Console.WriteLine("Modifying product according to"+ " "+ _v);
            
        }

        public override string ToString()
        {
            return base.ToString(); // REPLACE
        }
    }
}