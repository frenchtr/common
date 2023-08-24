using System;
using System.Collections.Generic;

namespace TravisRFrench.Common.Runtime.Registration
{
    public class Registrar<TEntity> : IRegistrar<TEntity>
    {
        protected List<TEntity> Entities { get; }
        IEnumerable<TEntity> IRegistrar<TEntity>.Entities => this.Entities;

        public Registrar()
        {
            this.Entities = new List<TEntity>();
        }

        public event Action<TEntity> Registered;
        public event Action<TEntity> Deregistered;
        
        public virtual void Register(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            if (this.Entities.Contains(entity))
            {
                return;
            }
            
            this.Entities.Add(entity);
            this.Registered?.Invoke(entity);
        }

        public virtual void Deregister(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            
            if (!this.Entities.Contains(entity))
            {
                return;
            }
            
            this.Entities.Remove(entity);
            this.Deregistered?.Invoke(entity);
        }
    }
}
