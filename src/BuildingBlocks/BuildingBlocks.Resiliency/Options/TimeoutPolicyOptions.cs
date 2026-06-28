using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingBlocks.Resiliency.Options;

public class TimeoutPolicyOptions
{
    public int TimeoutInSeconds { get; set; } = 30;
}
