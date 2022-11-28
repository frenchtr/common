namespace TravisRFrench.Common.Runtime.Timing
{
    public interface IStopwatch :
        ITimer, 
        IStartable<IStopwatch>, 
        IStoppable<IStopwatch>, 
        IResettable<IStopwatch>,
        IRestartable<IStopwatch>,
        IHasTime
    {
    }
}
