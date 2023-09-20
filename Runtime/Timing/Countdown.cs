using System;
using UnityEngine;

namespace TravisRFrench.Common.Runtime.Timing
{
    [Serializable]
    public class Countdown : Elapsable<ICountdown>, ICountdown
    {
        public Countdown(float duration) : base(duration)
        {
            this.Time = duration;
        }

        public Countdown()
        {
            this.Time = this.Duration;
        }
        
        public override event Action<ICountdown> Elapsed;

        public override void Tick(float deltaTime)
        {
            if (this.IsRunning)
            {
                if (this.Time <= 0f)
                {
                    this.Time = 0f;
                    this.HasElapsed = true;
                    this.Stop();
                    this.Elapsed?.Invoke(this);
                }
                else
                {
                    this.Time = Mathf.Clamp(this.Time - deltaTime, 0f, this.Duration);
                }
            }
        }

        public override void Reset()
        {
            this.Time = this.Duration;
            base.Reset();
        }
    }
}
