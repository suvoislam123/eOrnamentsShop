using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingBlocks.Core.Exception;

public class ConcurrencyException<TId> : DomainException
{
    public ConcurrencyException(TId id)
        : base($"A different version than expected was found in aggregate {id}") { }
}