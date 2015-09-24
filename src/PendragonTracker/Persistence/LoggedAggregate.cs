namespace PendragonTracker.Persistence
{
    using System;
    using System.Collections.Generic;
    using PendragonTracker.Identities;

    public class LoggedAggregate : IGuidEntity
    {
        public Guid Id
        {
            get;
            set;
        }

        public virtual ICollection<LoggedEvent> Events
        {
            get;
            set;
        }

        public string SourceType
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
