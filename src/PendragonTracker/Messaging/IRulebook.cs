namespace PendragonTracker.Messaging
{
    public interface IRule
    {
    }

    public interface IRule<in TContext> : IRule
    {
        void Verify(TContext context);
    }

    public interface IRulebook<in TContext> : IRule<TContext>
    {
    }
}
