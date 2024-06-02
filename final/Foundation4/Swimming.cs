namespace FitnessTracker
{
    public class Swimming : Activity
    {
        private int _laps;
        private const double LapLengthInMeters = 50;
        private const double MetersToMilesConversionFactor = 0.000621371;

        public Swimming(DateTime date, int minutes, int laps)
            : base(date, minutes)

        {
            this._laps = laps;
        }

        public override double GetDistance() => (_laps * LapLengthInMeters) * MetersToMilesConversionFactor;

        public override double GetSpeed() => (GetDistance() / Minutes) * 60;

        public override double GetPace() => Minutes / GetDistance();
    }
}
