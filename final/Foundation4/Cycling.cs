namespace FitnessTracker
{
    public class Cycling : Activity
    {
        private double _speed; // in mph

        public Cycling(DateTime date, int minutes, double speed)
            : base(date, minutes)
        {
            this._speed = speed;
        }

        public override double GetDistance() => (_speed * Minutes) / 60;

        public override double GetSpeed() => _speed;

        public override double GetPace() => 60 / _speed;
    }
}
