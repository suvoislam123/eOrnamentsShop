using BuildingBlocks.Core.Exception;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingBlocks.Core.Domain.Exceptions;

public class InvalidDateException : BadRequestException
{
    public DateTime Date { get; }

    public InvalidDateException(DateTime date)
        : base($"Date: '{date}' is invalid.")
    {
        Date = date;
    }
}
