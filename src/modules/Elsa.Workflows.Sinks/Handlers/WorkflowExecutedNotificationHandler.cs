using Elsa.Mediator.Services;
using Elsa.Workflows.Core.Notifications;
using Elsa.Workflows.Runtime.Notifications;
using Elsa.Workflows.Sinks.Models;
using Elsa.Workflows.Sinks.Services;

namespace Elsa.Workflows.Sinks.Handlers;

/// <summary>
/// Dispatches workflow sinks in response to the <see cref="WorkflowExecuted"/> event.
/// </summary>
internal class WorkflowExecutedNotificationHandler : INotificationHandler<WorkflowExecuted>
{
    private readonly IWorkflowSinkDispatcher _dispatcher;
    public WorkflowExecutedNotificationHandler(IWorkflowSinkDispatcher dispatcher) => _dispatcher = dispatcher;
    public async Task HandleAsync(WorkflowExecuted notification, CancellationToken cancellationToken) => await _dispatcher.DispatchAsync(notification.WorkflowState, cancellationToken);
}