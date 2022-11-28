using NUnit.Framework;
using TravisRFrench.Common.Runtime.Timing;

namespace TravisRFrench.Common.Tests.Editor.Timing
{
    public class IntervalTests : IntervalCounterTests
    {
        [Test]
        public void GivenNewInterval_WhenResetIsInvoked_ItShouldSetTimeToZero()
        {
            // ARRANGE
            var interval = new Interval(1f);
            
            // ACT
            interval.Reset();
            
            // ASSERT
            Assert.AreEqual(0f, interval.Time);
        }
        
        [Test]
        public void GivenStartedInterval_WhenTickIsInvoked_ItShouldIncrementTheCountdownTime()
        {
            // ARRANGE
            var duration = 1f;
            var deltaTime = 0.15f;
            var interval = new Interval(duration);
            interval.Start();
            
            // ACT
            interval.Tick(deltaTime);
            
            // ASSERT
            Assert.AreEqual(0 + deltaTime, interval.Time);
        }
    }
}
