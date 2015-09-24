namespace PendragonTracker.Persistence
{
    using System;
    using PendragonTracker.Identities;

    public class LoggedEvent : IGuidEntity
    {
        public Guid Id
        {
            get;
            set;
        }

        public virtual LoggedAggregate Aggregate
        {
            get;
            set;
        }

        public Guid AggregateId
        {
            get;
            set;
        }

        public string Payload
        {
            get;
            set;
        }

        public string SourceType
        {
            get;
            set;
        }

        public DateTime Timestamp
        {
            get;
            set;
        }

        public int Version
        {
            get;
            set;
        }
    }
}
