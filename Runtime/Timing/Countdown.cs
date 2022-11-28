using System;
using UnityEngine;

namespace TravisRFrench.Common.Runtime.Timing
{
    public class Countdown : IntervalCounter<ICountdown>, ICountdown
    {
        public Countdown(float duration) : base(duration)
        {
            this.Time = duration;
        }

        public override void Tick(float deltaTime)
        {
            if (this.IsRunning)
            {
                this.Time = Mathf.Clamp(this.Time - deltaTime, 0f, this.Duration);                
            }
        }

        public override void Reset()
        {
            this.Time = this.Duration;
            base.Reset();
        }
    }
}
