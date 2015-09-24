namespace PendragonTracker.Identities
{
    using System;

    public interface IGuidEntity : IHasIdentity<GuidIdentity>
    {
        Guid Id
        {
            get;
            set;
        }
    }

    public sealed class GuidIdentity
    {
        public GuidIdentity(Guid id)
        {
            this.Id = id;
        }

        public Guid Id
        {
            get;
        }
    }
}
