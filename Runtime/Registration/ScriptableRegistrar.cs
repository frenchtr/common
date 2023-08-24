using System;
using System.Collections.Generic;

namespace TravisRFrench.Common.Runtime.Registration
{
    public abstract class ScriptableRegistrar<TEntity> : ScriptableObject, IRegistrar<TEntity>
    {
        private Registrar<TEntity> registrar;
        
        public IEnumerable<TEntity> Entities => this.registrar.Entities;

        public event Action<TEntity> Registered
        {
            add => this.registrar.Registered += value;
            remove => this.registrar.Registered -= value;
        }
        public event Action<TEntity> Deregistered
        {
            add => this.registrar.Deregistered += value;
            remove => this.registrar.Deregistered -= value;
        }

        public void Register(TEntity entity) => this.registrar.Register(entity);
        public void Deregister(TEntity entity) => this.registrar.Deregister(entity);
    }
}
