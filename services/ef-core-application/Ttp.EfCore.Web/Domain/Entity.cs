using System;

namespace Ttp.EfCore.Web.Domain
{
    public abstract class Entity : Entity<Guid>, IEntity
    {
    }

    public abstract class Entity<TPrimaryKey> : IEntity<TPrimaryKey>
    {
        public TPrimaryKey Id { get; set; }
    }
}
