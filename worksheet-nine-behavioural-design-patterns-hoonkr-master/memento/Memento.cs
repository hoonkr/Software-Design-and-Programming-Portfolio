namespace worksheet_nine_behavioural_design_patterns
{
    public class Memento
    {
        private double x;
        private double y;
        public Memento(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double X() => x;
        public double Y() => y;

    }
}