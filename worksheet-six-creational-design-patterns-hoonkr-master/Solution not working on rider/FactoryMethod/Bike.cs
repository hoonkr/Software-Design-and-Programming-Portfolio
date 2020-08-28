using System;

namespace QuestionThree
{
    public class Bike:IProduct
    {
        public void Drive(int miles)
        {
            Console.WriteLine($"Drive the Bike: {miles} km");
        }
    }
}