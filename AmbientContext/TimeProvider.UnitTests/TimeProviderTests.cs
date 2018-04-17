using NUnit.Framework;
using FluentAssert;
using System;

namespace TimeProvider.UnitTests
{
    [TestFixture]
    public class TimeProviderTests
    {
        [Test]
        public void Now_ProviderHasNotBeenExplicitlySet_ReturnsDateTimeNow()
        {
            DateTime now = TimeProvider.Current.Now;

            DateTime.Now.AddSeconds(1).ShouldBeGreaterThan(now);
        }

        [Test]
        public void Now_ProviderHasBeenSet_ReturnsDateTimeInFuture()
        {
            var dateTime = new DateTime(2019, 2, 15, 8, 46, 13);

            TimeProvider.Current = new FakeTimeProvider(dateTime);
            DateTime now = TimeProvider.Current.Now;

            dateTime.ShouldBeEqualTo(now);
            
            TimeProvider.ResetToDefault();
        }
    }
}
