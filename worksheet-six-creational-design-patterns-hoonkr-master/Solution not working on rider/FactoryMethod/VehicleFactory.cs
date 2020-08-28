namespace QuestionThree
{
    public abstract class VehicleFactory
    {
        public abstract IProduct GetVehicle(string Vehicle);
    }
}