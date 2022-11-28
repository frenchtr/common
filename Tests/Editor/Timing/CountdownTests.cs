using NUnit.Framework;
using TravisRFrench.Common.Runtime.Timing;

namespace TravisRFrench.Common.Tests.Editor.Timing
{
    [TestFixture]
    [Category(EditorTestCategories.UnitTests)]
    public class CountdownTests : IntervalCounterTests
    {
        [Test]
        public void GivenNewCountdown_WhenConstructed_TimeShouldBeSetToDuration()
        {
            // ARRANGE
            

            // ACT
            var countdown = new Countdown(1f);
            
            // ASSERT
            Assert.AreEqual(countdown.Duration, countdown.Time);
        }
        
        [Test]
        public void GivenNewCountdown_WhenReset_ItShouldSetTimeToCountdownDuration()
        {
            // ARRANGE
            var countdown = new Countdown(1f);
            
            // ACT
            countdown.Reset();
            
            // ASSERT
            Assert.AreEqual(countdown.Duration, countdown.Time);
        }

        [Test]
        public void GivenStartedCountdown_WhenTicked_ItShouldDecrementTheCountdownTime()
        {
            // ARRANGE
            var duration = 1f;
            var deltaTime = 0.15f;
            var countdown = new Countdown(duration);
            countdown.Start();
            
            // ACT
            countdown.Tick(deltaTime);
            
            // ASSERT
            Assert.AreEqual(duration - deltaTime, countdown.Time);
        }
    }
}
