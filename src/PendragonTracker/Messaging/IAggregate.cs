namespace PendragonTracker.Messaging
{
    using System;

    public interface IAggregate
    {
        Guid Id
        {
            get;
            // set;
        }

        int Version
        {
            get;
            // set;
        }

        void Apply(IEvent item);
    }
}
