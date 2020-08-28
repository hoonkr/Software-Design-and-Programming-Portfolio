namespace Decorator
{
    public class Spinach:IPizza
    {
        private IPizza _pizza;

        public Spinach(IPizza pizza)
        {
            _pizza = pizza;
        }

        string IPizza.Description() => _pizza.Description() + ", Spinich (7.92)";

        decimal IPizza.Price()=> _pizza.Price() + (decimal)7.92;
    }
}