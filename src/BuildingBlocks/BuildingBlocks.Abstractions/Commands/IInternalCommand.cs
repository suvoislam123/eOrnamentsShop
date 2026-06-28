using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingBlocks.Abstractions.Commands;

public interface IInternalCommand : ICommand
{
    Guid InternalCommandId { get; }
    DateTime OccurredOn { get; }
    string Type { get; }
}

