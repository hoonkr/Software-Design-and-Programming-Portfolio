namespace Decorator
{
    public class GreenOlives:IPizza
    {
        private IPizza _pizza;

        public GreenOlives(IPizza pizza)
        {
            _pizza = pizza;
        }
        string IPizza.Description() => _pizza.Description() + ", Green Olives(5.47)";

        decimal IPizza.Price()=> _pizza.Price() + (decimal)5.47; 
    }
}