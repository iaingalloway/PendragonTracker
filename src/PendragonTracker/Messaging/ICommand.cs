namespace PendragonTracker.Messaging
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ICommand<TAggregate> : ICommand
    {
    }

    public interface ICommand
    {
    }

    public interface ICommandBus<TAggregate>
    {
        void Send<TCommand>(TCommand payload)
            where TCommand : class, ICommand<TAggregate>;

        Task SendAsync<TCommand>(TCommand payload)
            where TCommand : class, ICommand<TAggregate>;
    }

    public interface ICommandDispatcher
    {
        IEnumerable<ICommandHandler<T, TAggregate>> GetHandlers<T, TAggregate>();
    }

    public interface ICommandHandler
    {
    }

    public interface ICommandHandler<in TCommand, in TAggregate>
        : ICommandHandler
    {
        IEnumerable<IEvent> Handle(TAggregate aggregate, TCommand payload);
    }

    public interface ICommandSerializer
    {
        ICommand Deserialize(string body, Type type);

        string Serialize(ICommand payload);
    }
}
