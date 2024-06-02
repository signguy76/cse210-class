namespace FitnessTracker
{
    public abstract class Activity
    {
        private DateTime _date;
        private int _minutes;

        protected Activity(DateTime date, int minutes)
        {
            this._date = date;
            this._minutes = minutes;
        }

        public int Minutes => _minutes;
        public DateTime Date => _date;

        public abstract double GetDistance(); // in miles or kilometers
        public abstract double GetSpeed();    // in mph or kph
        public abstract double GetPace();     // in min per mile or min per km

        public virtual string GetSummary()
        {
            return $"{_date.ToString("dd MMM yyyy")} {GetType().Name} ({_minutes} min)- Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
        }
    }
}
