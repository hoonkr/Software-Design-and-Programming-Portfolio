namespace QuestionTwo
{
    public class SportsCarBuilder: ICarBuilder
    {
        private ICar _car = new SportsCar("SPORTS");
        public ICar GetCar()
        {
            return _car;
        }

        public void BuildBodystyle()
        {
            _car.BodyStyle =
                "External dimensions: overall length (inches): 192.3, overall width (inches): 75.5, overall height (inches): 54.2, wheelbase (inches): 112.3, front track (inches): 63.7, rear track (inches): 64.1 and curb to curb turning circle (feet): 37.7";
        }

        public void BuildPower()
        {
            _car.Power = "323 hp @ 6,800 rpm; 278 ft lb of torque @ 4,800 rpm";
        }

        public void BuildEngine()
        {
            _car.Engine = "3.6L V 6 DOHC and variable valve timing";
        }

        public void BuildBreaks()
        {
            _car.Brakes = "Four-wheel disc brakes: two ventilated. Electronic brake distribution. StabiliTrak stability control";
        }

        public void BuildSeats()
        {
            _car.Seats = "Driver sports front seat with one power adjustments manual height, front passenger seat sports front seat with one power adjustments";
        }

        public void BuildWindows()
        {
            _car.Windows = "Front windows with one-touch on two windows";
        }

        public void BuildFuelType()
        {
            _car.FuelType = "Petrol 17 MPG city, 28 MPG motorway, 20 MPG combined and 380 mi. range";
        }

        private class SportsCar : Car
        {
            public SportsCar(string carType) : base(carType)
            {
                
            }
        }

        public void Build()
        {
            BuildBodystyle();
            BuildPower();
            BuildEngine();
            BuildBreaks();
            BuildSeats();
            BuildWindows();
            BuildFuelType();
        }
    }
}