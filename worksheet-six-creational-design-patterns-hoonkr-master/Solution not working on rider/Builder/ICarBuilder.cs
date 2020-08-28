namespace QuestionTwo
{
    public interface ICarBuilder
    {
        void BuildBodystyle();
        void BuildPower();
        void BuildEngine();
        void BuildBreaks();
        void BuildSeats();
        void BuildWindows();
        void BuildFuelType();
        ICar GetCar();

    }
}