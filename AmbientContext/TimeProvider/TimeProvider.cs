using System;

namespace TimeProvider
{
    public abstract class TimeProvider
    {
        private static TimeProvider _current;

        static TimeProvider()
        {
            _current = new DefaultTimeProvider();
        }

        public static TimeProvider Current
        {
            get { return _current; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value));
                }

                _current = value;
            }
        }

        public abstract DateTime UtcNow { get; }
        public abstract DateTime Now { get; }
        public abstract DateTime Today { get; }

        public static void ResetToDefault()
        {
            _current = new DefaultTimeProvider();
        }
    }
}
