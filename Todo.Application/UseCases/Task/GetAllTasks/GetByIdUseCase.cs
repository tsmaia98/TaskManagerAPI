using Todo.Communication.Responses;

namespace Todo.Application.UseCases.Task.GetAllTasks;

public class GetByIdUseCase
{
    public ResponseTaskJson Execute(int id)
    {
        return new ResponseTaskJson
        {
            Id = id,
            Name =  "Test",
            Description = "Test",
            Status = 0,
            Prio = 0
        };
    }
}
