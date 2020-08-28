namespace AlarmSystem
{
    public static class Factory
    {
        public static ControlUnit CreateControlUnit()
        {
            return new ControlUnit();
        }

        public static SecurityControlUnit CreateSecurityControlUnit()
        {
            return new SecurityControlUnit();
        }

        public static FireSensor CreateFireSensor(double battery)
        {
            return new FireSensor(battery);
        }

        public static SmokeSensor CreateSmokeSensor(double battery)
        {
            return new SmokeSensor(battery);
        }

        public static MotionSensor CreateMotionSensor()
        {
            return new MotionSensor();
        }

        public static HeatSensor CreateHeatSensor()
        {
            return new HeatSensor();
        }
    }
}