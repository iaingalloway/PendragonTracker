namespace PendragonTracker.Messaging
{
    using System;

    public interface IQuery
    {
    }

    public interface IQuery<out TResponse> : IQuery
    {
    }

    public interface IQueryBus
    {
        TResponse Resolve<TResponse>(IQuery<TResponse> query);
    }

    public interface IQueryDispatcher
    {
        Func<IQuery<TResponse>, TResponse> GetHandler<TResponse>();
    }

    public interface IQueryHandler<in TQuery, out TResponse>
        where TQuery : IQuery<TResponse>
    {
        TResponse Handle(TQuery query);
    }
}
