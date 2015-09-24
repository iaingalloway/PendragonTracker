namespace PendragonTracker.Messaging
{
    using PendragonTracker.Identities;

    // ReSharper disable once TypeParameterCanBeVariant

    public interface IUpdateReadStore<TEntity, TIdentity>
        where TEntity : IHasIdentity<TIdentity>
    {
        TIdentity ReadStoreIdentity
        {
            get;
        }
    }
}
