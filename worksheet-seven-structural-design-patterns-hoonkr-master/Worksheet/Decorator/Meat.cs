namespace Decorator
{
    public class Meat:IPizza
    {
        private IPizza _pizza;
        public Meat(IPizza pizza)
        {
            _pizza = pizza;
        }

        string IPizza.Description()=> _pizza.Description() + ", Meat (14.25)";

        decimal IPizza.Price()=> _pizza.Price() + (decimal)14.25; 
    }
}