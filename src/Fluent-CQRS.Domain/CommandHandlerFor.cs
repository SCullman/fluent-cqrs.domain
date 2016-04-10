using Fluent_CQRS.Fluentation;

namespace Fluent_CQRS
{
    public abstract class CommandHandlerFor<TAggregate> : Handler<IAmACommandMessage> where TAggregate : Aggregate
    {
        private Aggregates _aggregateContext;

        public CommandHandlerFor(Aggregates aggregateContext)
        {
            _aggregateContext = aggregateContext;
        }

        public IInvokeActionsOnAggregates<TAggregate> With(IAmACommandMessage cmd)
        {
            return _aggregateContext.Provide<TAggregate>().With(cmd);
        }
    }
}
