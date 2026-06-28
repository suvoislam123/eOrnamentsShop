using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingBlocks.Resiliency.Options;

public class BulkheadPolicyOptions
{
    public int MaxParallelization { get; set; } = 10;
    public int MaxQueuingActions { get; set; } = 5;
}

