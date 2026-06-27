using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace BuildingBlocks.Abstractions.Core.Diagnostics;

public interface IActivityRunner
{
    Activity? CreateAndStartActivity(CreateActivityInfo createActivityInfo);

    Task ExecuteActivityAsync(
        CreateActivityInfo createActivityInfo,
        Func<Activity?, CancellationToken, Task> action,
        CancellationToken cancellationToken = default
    );

    Task<TResult?> ExecuteActivityAsync<TResult>(
        CreateActivityInfo createActivityInfo,
        Func<Activity?, CancellationToken, Task<TResult>> action,
        CancellationToken cancellationToken = default
    );
}