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

        public override void Tick(float deltaTime)
        {
            if (this.IsRunning)
            {
                this.Time = Mathf.Clamp(this.Time + deltaTime, 0f, this.Duration);                
            }
        }

        public override void Reset()
        {
            this.Time = 0f;
            base.Reset();
        }
    }
}
