using aspnet_backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_backend.Controllers;

/// <summary>
/// Provides endpoints for managing events.
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class EventsController : ControllerBase
{

    /// <summary>
    /// Retrieves all events.
    /// </summary>
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok();
    }

    /// <summary>
    /// Retrieves an event by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the event.</param>
    [HttpGet("{id:guid}")]
    public IActionResult GetById(Guid id)
    {
        return Ok();
    }

    /// <summary>
    /// Creates a new event.
    /// </summary>
    /// <param name="eventItem">The event to be created.</param>
    [HttpPost]
    public IActionResult Create(Event @event)
    {
        return CreatedAtAction(
            nameof(GetById),
            new { id = @event.Id },
            @event
        );
    }

    /// <summary>
    /// Updates an existing event.
    /// </summary>
    /// <param name="id">The unique identifier of the event.</param>
    /// <param name="eventItem">The updated event data.</param>
    [HttpPut("{id:guid}")]
    public IActionResult Update(Guid id, Event @event)
    {
        return NoContent();
    }

    /// <summary>
    /// Deletes an event.
    /// </summary>
    /// <param name="id">The unique identifier of the event.</param>
    [HttpDelete("{id:guid}")]
    public IActionResult Delete(Guid id)
    {
        return NoContent();
    }
}