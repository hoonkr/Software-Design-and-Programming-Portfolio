using System;

namespace Decorator
{
    public class SimplyVegPizza : IPizza
    {
        public string Description()
        {
            return "SimplyVegPizza (230)";
        }

        public decimal Price()
        {
            return 230;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}