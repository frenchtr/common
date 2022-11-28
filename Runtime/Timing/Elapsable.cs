using System;
using UnityEngine;

namespace TravisRFrench.Common.Runtime.Timing
{
    [Serializable]
    public abstract class Elapsable<TTimer> : Timer, IElapsable<TTimer>
        where TTimer : class, IElapsable<TTimer>
    {
        [field: SerializeField]
        public float Time { get; protected set; }
        [field: SerializeField]
        public float Duration { get; protected set; }

        protected Elapsable(float duration)
        {
            this.Duration = duration;
        }

        protected Elapsable()
        {
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
