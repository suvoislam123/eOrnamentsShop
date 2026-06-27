using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingBlocks.Abstractions.Web;

public interface IProblemDetailMapper
{
    int GetMappedStatusCodes(Exception? exception);
}
