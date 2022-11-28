using System;

namespace TravisRFrench.Common.Runtime.Timing
{
    public interface IResettable<out TTimer>
    {
        event Action<TTimer> Resetted;

        void Reset();
    }
}
