using System;

namespace Decorator
{
    public class RomaTomatoes:IPizza
    {
        private IPizza _pizza;
        public RomaTomatoes(IPizza pizza)
        {
            _pizza = pizza;
        }
        string IPizza.Description()=> _pizza.Description() + ", Roma Tomatoes (5.20)";
       
        decimal IPizza.Price()=> _pizza.Price() + (decimal)5.20;
    }
}