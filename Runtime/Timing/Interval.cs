using System;
using UnityEngine;

namespace TravisRFrench.Common.Runtime.Timing
{
    [Serializable]
    public class Interval : Elapsable<IInterval>, IInterval
    {
        public Interval(float duration) : base(duration)
        {
        }

        public Interval()
        {
        }
        
        public override event Action<IInterval> Elapsed;

        public override void Tick(float deltaTime)
        {
            if (this.IsRunning)
            {
                if (this.Time >= this.Duration)
                {
                    this.Time = this.Duration;
                    this.HasElapsed = true;
                    this.Elapsed?.Invoke(this);
                    this.Stop();
                }
                else
                {
                    this.Time = Mathf.Clamp(this.Time + deltaTime, 0f, this.Duration); 
                }
            }
        }

        public override void Reset()
        {
            this.Time = 0f;
            base.Reset();
        }
    }
}
