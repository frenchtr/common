using NUnit.Framework;

namespace TravisRFrench.Common.Tests.Editor.Timing
{
    [TestFixture]
    [Category(EditorTestCategories.UnitTests)]
    public abstract class EllapsableTests
    {
        [Test]
        public void GivenNewEllapsable_WhenStarted_ItShouldBeRunning()
        {
            // ARRANGE
            var ellapsable = new FakeElapsable(1f);
            
            // ACT
            ellapsable.Start();
            
            // ASSERT
            Assert.IsTrue(ellapsable.IsRunning);
        }

        [Test]
        public void GivenNewEllapsable_WhenStopped_ItShouldNotBeRunning()
        {
            // ARRANGE
            var ellapsable = new FakeElapsable(1f);
            
            // ACT
            ellapsable.Stop();
            
            // ASSERT
            Assert.IsFalse(ellapsable.IsRunning);
        }
        
        [Test]
        public void GivenNewEllapsable_WhenReset_ItShouldNotBeRunning()
        {
            // ARRANGE
            var ellapsable = new FakeElapsable(1f);
            
            // ACT
            ellapsable.Reset();
            
            // ASSERT
            Assert.IsFalse(ellapsable.IsRunning);
        }
    }
}
