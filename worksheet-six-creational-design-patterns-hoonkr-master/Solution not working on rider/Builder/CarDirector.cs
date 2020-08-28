namespace QuestionTwo
{
    public class CarDirector : ICarDirector
    {
        private ICarBuilder _carBuilder;
        public CarDirector(ICarBuilder cb)
        {
            _carBuilder = cb;
        }

        public void Build()
        {
            _carBuilder.BuildBodystyle();
            _carBuilder.BuildBreaks();
            _carBuilder.BuildEngine();
            _carBuilder.BuildFuelType();
            _carBuilder.BuildSeats();
            _carBuilder.BuildWindows();
            _carBuilder.BuildPower();
            
        }
    }
}