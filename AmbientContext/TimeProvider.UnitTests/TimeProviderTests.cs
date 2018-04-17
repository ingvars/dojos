using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TimeProvider.UnitTests
{
    [TestClass]
    public class TimeProviderTests
    {
        [TestMethod]
        public void Now_ProviderHasNotBeenExplicitlySet_ReturnsDateTimeNow()
        {
            DateTime now = TimeProvider.Current.Now;

            Assert.IsTrue(now.AddSeconds(10) > DateTime.Now);
        }

        [TestMethod]
        public void Now_ProviderHasBeenSet_ReturnsDateTimeInFuture()
        {
            var dateTime = new DateTime(2019, 2, 15, 8, 46, 13);

            TimeProvider.Current = new FakeTimeProvider(dateTime);
            DateTime now = TimeProvider.Current.Now;

            Assert.AreEqual(dateTime, now);

            TimeProvider.ResetToDefault();
        }
    }
}
