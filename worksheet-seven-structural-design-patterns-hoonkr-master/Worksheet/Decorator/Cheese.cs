namespace Decorator
{
    public class Cheese : IPizza
    {
        private IPizza _pizza;
        public Cheese(IPizza pizza)
        {
            _pizza = pizza;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        string IPizza.Description() =>_pizza.Description() + ", Cheese (20.72)";

        decimal IPizza.Price()=> _pizza.Price() + (decimal)20.72; 
    }
}