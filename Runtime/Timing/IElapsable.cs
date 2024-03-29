﻿using System;

namespace TravisRFrench.Common.Runtime.Timing
{
    public interface IElapsable<out TTimer> :
        ITimer, 
        IStartable<TTimer>, 
        IStoppable<TTimer>, 
        IResettable<TTimer>,
        IRestartable<TTimer>,
        IHasTime,
        IHasDuration
    {
        bool HasElapsed { get; }

        event Action<TTimer> Elapsed;
    }
}
