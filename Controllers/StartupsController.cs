using aspnet_backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_backend.Controllers;

/// <summary>
/// Provides endpoints for managing startups.
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class StartupsController : ControllerBase
{

    /// <summary>
    /// Retrieves all startups.
    /// </summary>
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok();
    }

    /// <summary>
    /// Retrieves a startup by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the startup.</param>
    [HttpGet("{id:guid}")]
    public IActionResult GetById(Guid id)
    {
        return Ok();
    }

    /// <summary>
    /// Creates a new startup.
    /// </summary>
    /// <param name="startup">The startup to be created.</param>
    [HttpPost]
    public IActionResult Create(Startup startup)
    {
        return CreatedAtAction(
            nameof(GetById),
            new { id = startup.Id },
            startup
        );
    }

    /// <summary>
    /// Updates an existing startup.
    /// </summary>
    /// <param name="id">The unique identifier of the startup.</param>
    /// <param name="startup">The updated startup data.</param>
    [HttpPut("{id:guid}")]
    public IActionResult Update(Guid id, Startup startup)
    {
        return NoContent();
    }

    /// <summary>
    /// Deletes a startup.
    /// </summary>
    /// <param name="id">The unique identifier of the startup.</param>
    [HttpDelete("{id:guid}")]
    public IActionResult Delete(Guid id)
    {
        return NoContent();
    }
}