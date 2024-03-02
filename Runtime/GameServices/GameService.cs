using UnityEngine;

namespace TravisRFrench.Common.Runtime.GameServices
{
    public abstract class GameService : ScriptableObject, IGameService
    {
        public virtual void Setup()
        {
        }

        public virtual void Tick(float deltaTime)
        {
        }

        public virtual void Teardown()
        {
        }
    }
}
