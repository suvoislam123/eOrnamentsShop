using BuildingBlocks.Abstractions.Messages;
using MassTransit;

namespace BuildingBlocks.Core.Messages;

public abstract record Message : IMessage
{
    public Guid MessageId => NewId.NextGuid();
    public DateTime Created { get; } = DateTime.Now;
}
