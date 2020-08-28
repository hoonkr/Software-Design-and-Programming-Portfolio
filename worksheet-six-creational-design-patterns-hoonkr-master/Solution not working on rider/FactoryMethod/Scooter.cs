using System;

namespace QuestionThree
{
    public class Scooter : IProduct
    {
        public void Drive(int miles)
        {
            Console.WriteLine($"Drive the Scooter: {miles} km");
        }
    }
}