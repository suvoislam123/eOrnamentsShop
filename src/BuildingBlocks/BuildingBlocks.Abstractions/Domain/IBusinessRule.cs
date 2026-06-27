using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingBlocks.Abstractions.Domain;

public interface IBusinessRule
{
    string Message { get; }
    int Status { get; }
    bool IsBroken();
}
