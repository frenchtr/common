using System.Collections.Generic;

namespace TravisRFrench.Common.Runtime.Registration
{
    public interface IRegistrar<TEntity>
    {
        IEnumerable<TEntity> Entities { get; }

        void Register(TEntity entity);
        void Deregister(TEntity entity);
    }
}
