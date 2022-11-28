using System;

namespace TravisRFrench.Common.Runtime.Timing
{
    public class Stopwatch : Timer, IStopwatch
    {
        public float Time { get; private set; }
        
        public event Action<IStopwatch> Started;
        public event Action<IStopwatch> Stopped;
        public event Action<IStopwatch> Resetted;

        public void Start()
        {
            this.IsRunning = true;
            this.Started?.Invoke(this);
        }

        public void Stop()
        {
            this.IsRunning = false;
            this.Stopped?.Invoke(this);
        }

        public void Reset()
        {
            this.Time = 0f;
            this.Resetted?.Invoke(this);
        }

        public override void Tick(float deltaTime)
        {
            if (this.IsRunning)
            {
                this.Time += deltaTime;
            }
        }
    }
}
