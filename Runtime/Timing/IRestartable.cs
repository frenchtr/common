namespace TravisRFrench.Common.Runtime.Timing
{
    public interface IRestartable<out TTimer> : IStartable<TTimer>, IStoppable<TTimer>
    {
    }

    public static class Restartable
    {
        public static void Restart<TTimer>(this IRestartable<TTimer> timer)
        {
            timer.Stop();
            timer.Start();
        }
    }
}
