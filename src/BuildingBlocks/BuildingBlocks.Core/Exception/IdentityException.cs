using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingBlocks.Core.Exception;

public class IdentityException(
    string message,
    int statusCode = StatusCodes.Status400BadRequest,
    System.Exception? innerException = null,
    params string[] errors
) : CustomException(message, statusCode, innerException, errors);

