using BuildingBlocks.Core.Exception;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingBlocks.Core.Domain.Exceptions;

public class InvalidEmailException : BadRequestException
{
    public string Email { get; }

    public InvalidEmailException(string email)
        : base($"Email: '{email}' is invalid.")
    {
        Email = email;
    }
}
