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
        
        public void Register(TEntity entity)
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
        }

        public void Deregister(TEntity entity)
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
        }
    }
}
