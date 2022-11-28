using System;

namespace TravisRFrench.Common.Runtime.Timing
{
    public interface IStoppable<out TTimer>
    {
        event Action<TTimer> Stopped;

        void Stop();
    }
}
