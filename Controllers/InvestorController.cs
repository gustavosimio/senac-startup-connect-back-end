using aspnet_backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_backend.Controllers;

/// <summary>
/// Provides endpoints for managing investors.
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class InvestorController : ControllerBase
{

    /// <summary>
    /// Retrieves all investors.
    /// </summary>
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok();
    }

    /// <summary>
    /// Retrieves an investor by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the investor.</param>
    [HttpGet("{id:guid}")]
    public IActionResult GetById(Guid id)
    {
        return Ok();
    }

    /// <summary>
    /// Creates a new investor.
    /// </summary>
    /// <param name="investor">The investor to be created.</param>
    [HttpPost]
    public IActionResult Create(Investor investor)
    {
        return CreatedAtAction(
            nameof(GetById),
            new { id = investor.Id },
            investor
        );
    }

    /// <summary>
    /// Updates an existing investor.
    /// </summary>
    /// <param name="id">The unique identifier of the investor.</param>
    /// <param name="investor">The updated investor data.</param>
    [HttpPut("{id:guid}")]
    public IActionResult Update(Guid id, Investor investor)
    {
        return NoContent();
    }

    /// <summary>
    /// Deletes an investor.
    /// </summary>
    /// <param name="id">The unique identifier of the investor.</param>
    [HttpDelete("{id:guid}")]
    public IActionResult Delete(Guid id)
    {
        return NoContent();
    }
}