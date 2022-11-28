namespace TravisRFrench.Common.Runtime.Timing
{
    public interface ITimer
    {
        bool IsRunning { get; }
        
        void Tick(float deltaTime);
    }
}
