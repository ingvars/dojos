using System;

namespace TimeProvider.UnitTests
{
    internal class FakeTimeProvider : TimeProvider
    {
        public FakeTimeProvider(DateTime now)
        {
            UtcNow = now;
            Now = now;
            Today = now.Date;
        }

        public override DateTime UtcNow { get; }
        public override DateTime Now { get; }
        public override DateTime Today { get; }
    }
}
