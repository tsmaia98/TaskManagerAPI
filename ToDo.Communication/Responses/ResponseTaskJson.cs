using Todo.Communication.Enums;

namespace Todo.Communication.Responses;

public class ResponseTaskJson 
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public TaskStat Status { get; set; }
    public TaskPrio Prio { get; set; }

}
