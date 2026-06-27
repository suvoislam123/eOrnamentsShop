using BuildingBlocks.Core.Exception;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingBlocks.Core.Domain.Exceptions;

public class InvalidCurrencyException : BadRequestException
{
    public string Currency { get; }

    public InvalidCurrencyException(string currency)
        : base($"Currency: '{currency}' is invalid.")
    {
        Currency = currency;
    }
}
