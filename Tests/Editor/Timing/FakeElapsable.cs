using System;
using TravisRFrench.Common.Runtime.Timing;

namespace TravisRFrench.Common.Tests.Editor.Timing
{
    public class FakeElapsable : Elapsable<FakeElapsable>
    {
        public FakeElapsable(float duration) : base(duration)
        {
        }

        public override void Tick(float deltaTime)
        {
            throw new NotImplementedException();
        }

        public override event Action<FakeElapsable> Elapsed;
    }
}
