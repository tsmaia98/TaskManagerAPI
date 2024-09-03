using Todo.Communication.Responses;

namespace Todo.Application.UseCases.Task.GetAllTasks;

public class GetAllTasksUseCase
{
    public ResponseGetAllTaskJson Execute()
    {
        return new ResponseGetAllTaskJson()
        {
            Tasks = new List<ResponseTaskJson>
            {
                new ResponseTaskJson
                {
                 Id = 1,
                 Name = "Lavar lou�a",
                 Description = "Lavar, secar e guardar a lou�a",
                 Status = 0,
                 Prio = 0,

                }
            }
        };
    }
};