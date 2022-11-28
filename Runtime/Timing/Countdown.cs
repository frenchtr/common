using System;
using UnityEngine;

namespace TravisRFrench.Common.Runtime.Timing
{
    [Serializable]
    public class Countdown : IntervalCounter<ICountdown>, ICountdown
    {
        public Countdown(float duration) : base(duration)
        {
            this.Time = duration;
        }

        public Countdown()
        {
            this.Time = this.Duration;
        }

        public override void Tick(float deltaTime)
        {
            if (this.IsRunning)
            {
                this.Time = Mathf.Clamp(this.Time - deltaTime, 0f, this.Duration);                
            }
        }

        public override void Start()
        {
            base.Start();
        }

        public override void Reset()
        {
            this.Time = this.Duration;
            base.Reset();
        }
    }
}
