namespace TravisRFrench.Common.Runtime.Timing
{
    public interface IIntervalCounter<out TTimer> :
        ITimer, 
        IStartable<TTimer>, 
        IStoppable<TTimer>, 
        IResettable<TTimer>,
        IRestartable<TTimer>,
        IHasTime,
        IHasDuration
    {
    }
}
