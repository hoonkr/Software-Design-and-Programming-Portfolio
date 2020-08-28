namespace Decorator
{
    public class SimplyNonVegPizza : IPizza
    {
        public string Description()
        {
            return "SimplyNonVegPizza (350)";
        }

        public decimal Price()
        {
            return 350;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}