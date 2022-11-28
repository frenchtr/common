using System;
using TravisRFrench.Common.Runtime.Timing;

namespace TravisRFrench.Common.Tests.Editor.Timing
{
    public class FakeIntervalCounter : IntervalCounter<FakeIntervalCounter>
    {
        public FakeIntervalCounter(float duration) : base(duration)
        {
        }

        public override void Tick(float deltaTime)
        {
            throw new NotImplementedException();
        }
    }
}
