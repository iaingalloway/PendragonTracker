namespace PendragonTracker.Mapping
{
    public interface ITwoWayMapper : IOneWayMapper
    {
        TSource Apply<TSource, TTarget>(TTarget changes, TSource original);
    }
}
