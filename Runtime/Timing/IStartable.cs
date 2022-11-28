using System;

namespace TravisRFrench.Common.Runtime.Timing
{
    public interface IStartable<out TTimer>
    {
        event Action<TTimer> Started;

        void Start();
    }
}
