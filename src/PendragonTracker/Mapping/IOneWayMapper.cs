namespace PendragonTracker.Mapping
{
    using System;

    public interface IOneWayMapper
    {
        TTarget Map<TSource, TTarget>(TSource source);

        object Map(object source, Type sourceType, Type destinationType);
    }
}
