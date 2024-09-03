using Todo.Communication.Requests;
using Todo.Communication.Responses;

namespace Todo.Application.UseCases.Task.CreateTask;

public class CreateTaskUseCase
{
    public ResponseCreateTaskJson Execute(RequestTaskJson request)
    {
        return new ResponseCreateTaskJson
        {
            Id = request.Id,
            Name = request.Name,
            Description = request.Description,
            Type = request.Type,
            Created = request.Created,
            Deadline = request.Deadline,
            Status = request.Status,
        };
    }
}
