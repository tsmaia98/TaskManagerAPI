using Microsoft.AspNetCore.Mvc;
using Todo.Application.UseCases.Task.CreateTask;
using Todo.Application.UseCases.Task.DeleteTask;
using Todo.Application.UseCases.Task.GetAllTasks;
using Todo.Application.UseCases.Task.UpdateTask;
using Todo.Communication.Requests;
using Todo.Communication.Responses;

namespace TodoAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TaskController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseCreateTaskJson), 201)]
    [ProducesResponseType(400)]
    public IActionResult CreateTask(RequestTaskJson request)
    {
        var useCase = new CreateTaskUseCase();

        var response = useCase.Execute(request);


        return Created(string.Empty, 201);
    }

    [HttpGet]
    [ProducesResponseType(typeof(ResponseGetAllTaskJson), 200)]
    [ProducesResponseType(400)]
    public IActionResult GetAllTask()
    {
        var useCase = new GetAllTasksUseCase();

        var response = useCase.Execute();

        return Ok();
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseTaskJson), 200)]
    [ProducesResponseType(404)]
    public IActionResult GetById([FromRoute] int id)
    {
        var useCase = new GetByIdUseCase();

        var response = useCase.Execute(id);

        return Ok();
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(204)]
    [ProducesResponseType(typeof(ResponseErrorsJson), 400)]
    public IActionResult Update([FromRoute] int id, [FromBody] RequestTaskJson request) 
    {
        var useCase = new UpdateTaskUseCase();

        useCase.Execute(id, request);

        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(204)]
    [ProducesResponseType(typeof(ResponseErrorsJson), 400)]
    public IActionResult DeleteById([FromRoute] int id) 
    {
        var useCase = new DeleteTaskByIdUseCase();

        useCase.Execute(id);

        return NoContent();
    }
}