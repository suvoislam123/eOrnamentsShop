using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingBlocks.Abstractions.Persistence;

public interface IDbFacadeResolver
{
    DatabaseFacade Database { get; }
}