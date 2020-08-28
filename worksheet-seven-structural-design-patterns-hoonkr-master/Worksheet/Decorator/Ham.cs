namespace Decorator
{
    public class Ham:IPizza
    {
        private IPizza _pizza;
        public Ham(IPizza pizza)
        {
            _pizza = pizza;
        }
        string IPizza.Description() => _pizza.Description() + ", Ham (18.12)";

        decimal IPizza.Price()=> _pizza.Price() + (decimal)18.12;
    }
}