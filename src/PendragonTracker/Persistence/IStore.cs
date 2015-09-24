namespace PendragonTracker.Persistence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using PendragonTracker.Identities;
    using PendragonTracker.Messaging;

    public interface IStore<TEntity, TIdentity>
        where TEntity : IHasIdentity<TIdentity>
    {
        TEntity Create();

        void DeleteByIdentity(TIdentity identity);

        TEntity GetByIdentity(TIdentity identity);

        IQueryable<TEntity> GetByIdentityAsQueryable(TIdentity identity);

        TIdentity Insert(TEntity entity);

        void Insert(IEnumerable<TEntity> entities);

        IQueryable<TEntity> List();

        void Update(TEntity entity);

        void Update<TChanges>(TIdentity identity, TChanges changes);
    }

    public interface IEventStore
    {
        TAggregate Load<TAggregate>(Guid id)
            where TAggregate : class, IAggregate, new();

        void Save<TAggregate>(
            TAggregate aggregate,
            IEnumerable<IEvent> newEvents) where TAggregate : IAggregate;
    }

    public interface ICommandStore
    {
        void Insert(ICommand payload);
    }
}
