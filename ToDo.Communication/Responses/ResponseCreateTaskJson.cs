using Todo.Communication.Enums;

namespace Todo.Communication.Responses;

public class ResponseCreateTaskJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public TaskPrio Type { get; set; }
    public DateTime Created { get; set; }
    public DateTime Deadline { get; set; }
    public TaskStat Status { get; set; }
}
