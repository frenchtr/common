﻿using System;

namespace TravisRFrench.Common.Runtime.Timing
{
    public abstract class IntervalCounter<TTimer> : Timer, IIntervalCounter<TTimer>
        where TTimer : class, IIntervalCounter<TTimer>
    {
        public float Time { get; protected set; }
        public float Duration { get; }
        
        public IntervalCounter(float duration)
        {
            this.Duration = duration;
        }

        public virtual event Action<TTimer> Started;
        public virtual event Action<TTimer> Stopped;
        public virtual event Action<TTimer> Resetted;
        
        public virtual void Start()
        {
            this.IsRunning = true;
            this.Started?.Invoke(this as TTimer);
        }

        public virtual void Stop()
        {
            this.IsRunning = false;
            this.Stopped?.Invoke(this as TTimer);
        }

        public virtual void Reset()
        {
            this.IsRunning = false;
            this.Resetted?.Invoke(this as TTimer);
        }
    }
}