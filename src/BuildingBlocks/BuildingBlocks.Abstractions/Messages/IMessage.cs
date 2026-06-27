using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingBlocks.Abstractions.Messages;

public interface IMessage
{
    Guid MessageId { get; }
    DateTime Created { get; }
}
