namespace TravisRFrench.Common.Runtime.Timing
{
    public abstract class Timer : ITimer
    {
        public virtual bool IsRunning { get; protected set; }

        public abstract void Tick(float deltaTime);
    }
}
