namespace TravisRFrench.Common.Runtime.GameServices
{
    public interface IGameService
    {
        void Setup();
        void Tick(float deltaTime);
        void Teardown();
    }
}
