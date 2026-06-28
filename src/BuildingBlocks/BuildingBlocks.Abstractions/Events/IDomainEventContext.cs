using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingBlocks.Abstractions.Events;

public interface IDomainEventContext
{
    IReadOnlyList<IDomainEvent> DequeueUncommittedDomainEvents();
}

