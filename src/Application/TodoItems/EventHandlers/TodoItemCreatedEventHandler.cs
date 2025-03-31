using iot_management.Domain.Events;
using Microsoft.Extensions.Logging;

namespace iot_management.Application.TodoItems.EventHandlers;

public class TodoItemCreatedEventHandler : INotificationHandler<TodoItemCreatedEvent>
{
    private readonly ILogger<TodoItemCreatedEventHandler> _logger;

    public TodoItemCreatedEventHandler(ILogger<TodoItemCreatedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(TodoItemCreatedEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("iot_management Domain Event: {DomainEvent}", notification.GetType().Name);

        return Task.CompletedTask;
    }
}
