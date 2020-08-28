using System;

namespace Decorator
{
    public static class TestDecoratorPattern
    {
        public static void Main(string[] args)
        {
            IPizza pizza = new SimplyVegPizza();
            pizza = new RomaTomatoes(pizza);
            pizza = new GreenOlives(pizza);
            pizza = new Spinach(pizza);
            Console.WriteLine("Desc: "+ pizza.Description());
            Console.WriteLine("Price: "+ pizza.Price());
            
            pizza = new SimplyNonVegPizza();
            pizza = new Meat(pizza);
            pizza = new Cheese(pizza);
            pizza = new Ham(pizza);
            Console.WriteLine("Desc: "+ pizza.Description());
            Console.WriteLine("Price: "+ pizza.Price());

        }
    }
}