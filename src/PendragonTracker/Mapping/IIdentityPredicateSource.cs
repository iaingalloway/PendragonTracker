namespace PendragonTracker.Mapping
{
    using System;
    using System.Linq.Expressions;

    public interface IIdentityPredicateSource<TEntity, in TIdentity>
    {
        Expression<Func<TEntity, bool>> GetPredicateForIdentity(
            TIdentity identity);
    }
}
