using System;

namespace TimeProvider
{
    public class DefaultTimeProvider : TimeProvider
    {
        public override DateTime UtcNow => DateTime.UtcNow;
        public override DateTime Now => DateTime.Now;
        public override DateTime Today => DateTime.Today;
    }
}
