using System.Collections.Generic;

namespace TravisRFrench.Common.Runtime.Registration
{
    public interface IRegistrar<TEntity>
    {
        IEnumerable<TEntity> Entities { get; }

        event Action<TEntity> Registered;
        event Action<TEntity> Deregistered;

        void Register(TEntity entity);
        void Deregister(TEntity entity);
    }
}
