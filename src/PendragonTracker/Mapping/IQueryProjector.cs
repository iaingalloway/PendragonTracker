namespace PendragonTracker.Mapping
{
    using System.Linq;

    public interface IQueryProjector<in TEntity, out TProjection>
    {
        IQueryable<TProjection> Map(IQueryable<TEntity> query);
    }
}
