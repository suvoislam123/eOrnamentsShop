using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingBlocks.Abstractions.Web.Problem;

public interface IProblemDetailMapper
{
    int GetMappedStatusCodes(Exception? exception);
}
