using NUnit.Framework;
using TravisRFrench.Common.Runtime.Timing;

namespace TravisRFrench.Common.Tests.Editor.Timing
{
    [TestFixture]
    [Category(EditorTestCategories.UnitTests)]
    public class StopwatchTests
    {
        [Test]
        public void GivenNewStopwatch_WhenStarted_ItShouldBeRunning()
        {
            // ARRANGE
            var stopwatch = new Stopwatch();

            // ACT
            stopwatch.Start();
            
            // ASSERT
            Assert.IsTrue(stopwatch.IsRunning);
        }
        
        [Test]
        public void GivenNewStopwatch_WhenStopped_ItShouldNotBeRunning()
        {
            // ARRANGE
            var stopwatch = new Stopwatch();

            // ACT
            stopwatch.Stop();
            
            // ASSERT
            Assert.IsFalse(stopwatch.IsRunning);
        }
        
        [Test]
        public void GivenRunningStopwatch_WhenReset_ItShouldNotBeRunning()
        {
            // ARRANGE
            var stopwatch = new Stopwatch();

            // ACT
            stopwatch.Reset();
            
            // ASSERT
            Assert.IsFalse(stopwatch.IsRunning);
        }
        
        [Test]
        public void GivenNewStopwatch_WhenReset_ItShouldResetTheStopwatchTime()
        {
            // ARRANGE
            var stopwatch = new Stopwatch();

            // ACT
            stopwatch.Reset();
            
            // ASSERT
            Assert.AreEqual(0f, stopwatch.Time);
        }

        [Test]
        public void GivenRunningStopwatch_WhenTicked_ItShouldIncrementTheStopwatchTime()
        {
            // ARRANGE
            var deltaTime = 0.15f;
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            // ACT
            stopwatch.Tick(deltaTime);
            
            // ASSERT
            Assert.AreEqual(0 + deltaTime, stopwatch.Time);
        }

        [Test]
        public void GivenNotRunningStopwatch_WhenTicked_ItShouldNotIncrementTheStopwatchTime()
        {
            // ARRANGE
            var deltaTime = 0.15f;
            var stopwatch = new Stopwatch();

            // ACT
            stopwatch.Tick(deltaTime);
            
            // ASSERT
            Assert.AreEqual(0, stopwatch.Time);
        }
    }
}
