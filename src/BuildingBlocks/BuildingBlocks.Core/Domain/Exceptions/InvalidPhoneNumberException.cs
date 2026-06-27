using BuildingBlocks.Core.Exception;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingBlocks.Core.Domain.Exceptions;

public class InvalidPhoneNumberException : BadRequestException
{
    public string PhoneNumber { get; }

    public InvalidPhoneNumberException(string phoneNumber)
        : base($"PhoneNumber: '{phoneNumber}' is invalid.")
    {
        PhoneNumber = phoneNumber;
    }
}