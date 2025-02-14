using System;

namespace ExerciseTracking
{
    public abstract class Activity
    {
        private DateTime _date;
        private int _lengthInMinutes;

        public Activity(DateTime date, int lengthInMinutes)
        {
            _date = date;
            _lengthInMinutes = lengthInMinutes;
        }

        public DateTime Date => _date;
        public int LengthInMinutes => _lengthInMinutes;

        // Abstract methods to be overridden in derived classes
        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();

        // Virtual method to provide a summary
        public virtual string GetSummary()
        {
            return $"{_date.ToShortDateString()} {GetType().Name} ({_lengthInMinutes} min) - " +
                   $"Distance: {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
        }
    }
}