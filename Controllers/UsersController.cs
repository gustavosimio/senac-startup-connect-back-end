using aspnet_backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_backend.Controllers;

/// <summary>
/// Provides endpoints for managing users.
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{

    /// <summary>
    /// Retrieves all users.
    /// </summary>
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok();
    }

    /// <summary>
    /// Retrieves a user by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the user.</param>
    [HttpGet("{id:guid}")]
    public IActionResult GetById(Guid id)
    {
        return Ok();
    }

    /// <summary>
    /// Creates a new user.
    /// </summary>
    /// <param name="user">The user to be created.</param>
    [HttpPost]
    public IActionResult Create(User user)
    {
        return CreatedAtAction(
            nameof(GetById),
            new { id = user.Id },
            user
        );
    }

    /// <summary>
    /// Updates an existing user.
    /// </summary>
    /// <param name="id">The unique identifier of the user.</param>
    /// <param name="user">The updated user data.</param>
    [HttpPut("{id:guid}")]
    public IActionResult Update(Guid id, User user)
    {
        return NoContent();
    }

    /// <summary>
    /// Deletes a user.
    /// </summary>
    /// <param name="id">The unique identifier of the user.</param>
    [HttpDelete("{id:guid}")]
    public IActionResult Delete(Guid id)
    {
        return NoContent();
    }
}