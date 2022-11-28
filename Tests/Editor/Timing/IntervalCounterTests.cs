using NUnit.Framework;

namespace TravisRFrench.Common.Tests.Editor.Timing
{
    [TestFixture]
    [Category(EditorTestCategories.UnitTests)]
    public abstract class IntervalCounterTests
    {
        [Test]
        public void GivenNewIntervalCounter_WhenStarted_ItShouldBeRunning()
        {
            // ARRANGE
            var counter = new FakeIntervalCounter(1f);
            
            // ACT
            counter.Start();
            
            // ASSERT
            Assert.IsTrue(counter.IsRunning);
        }

        [Test]
        public void GivenNewIntervalCounter_WhenStopped_ItShouldNotBeRunning()
        {
            // ARRANGE
            var counter = new FakeIntervalCounter(1f);
            
            // ACT
            counter.Stop();
            
            // ASSERT
            Assert.IsFalse(counter.IsRunning);
        }
        
        [Test]
        public void GivenNewIntervalCounter_WhenReset_ItShouldNotBeRunning()
        {
            // ARRANGE
            var counter = new FakeIntervalCounter(1f);
            
            // ACT
            counter.Reset();
            
            // ASSERT
            Assert.IsFalse(counter.IsRunning);
        }
    }
}
