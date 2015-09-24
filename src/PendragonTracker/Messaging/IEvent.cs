namespace PendragonTracker.Messaging
{
    using System;
    using System.Collections.Generic;

    public interface IEvent
    {
        Guid AggregateId
        {
            get;
        }

        int Version
        {
            get;
        }
    }

    public interface IEventBus
    {
        void Publish(IEvent payload);
    }

    public interface IEventDispatcher
    {
        IEnumerable<Action<IEvent>> GetHandlers(Type type);
    }

    public interface IEventHandler<in T>
        where T : IEvent
    {
        void Handle(T payload);
    }

    public interface IEventSerializer
    {
        IEvent Deserialize(string body, Type type);

        string Serialize(IEvent payload);
    }
}
