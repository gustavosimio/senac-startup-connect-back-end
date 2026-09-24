using aspnet_backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_backend.Controllers;

/// <summary>
/// Provides endpoints for managing funding calls.
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class FundingCallsController : ControllerBase
{
    /// <summary>
    /// Retrieves all funding calls.
    /// </summary>
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok();
    }

    /// <summary>
    /// Retrieves a funding call by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the funding call.</param>
    [HttpGet("{id:guid}")]
    public IActionResult GetById(Guid id)
    {
        return Ok();
    }

    /// <summary>
    /// Creates a new funding call.
    /// </summary>
    /// <param name="fundingCall">The funding call to be created.</param>
    [HttpPost]
    public IActionResult Create(FundingCall fundingCall)
    {
        return CreatedAtAction(
            nameof(GetById),
            new { id = fundingCall.Id },
            fundingCall
        );
    }

    /// <summary>
    /// Updates an existing funding call.
    /// </summary>
    /// <param name="id">The unique identifier of the funding call.</param>
    /// <param name="fundingCall">The updated funding call data.</param>
    [HttpPut("{id:guid}")]
    public IActionResult Update(Guid id, FundingCall fundingCall)
    {
        return NoContent();
    }

    /// <summary>
    /// Deletes a funding call.
    /// </summary>
    /// <param name="id">The unique identifier of the funding call.</param>
    [HttpDelete("{id:guid}")]
    public IActionResult Delete(Guid id)
    {
        return NoContent();
    }
}