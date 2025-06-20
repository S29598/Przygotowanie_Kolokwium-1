using APDB_Kolokwium_template.Services;
using Microsoft.AspNetCore.Mvc;

namespace APDB_Kolokwium_template.Controllers;

[ApiController]
[Route("/api")]
public class ExampleController(IDbService service) : ControllerBase
{
    [HttpGet]
    [Route("/enrollments")]
    public async Task<IActionResult> GetEnrollments()
    {
        try
        {
            return Ok(await service.GetEnrollments());
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    /*[HttpGet]
    [Route("/examples")]
    public async Task<IActionResult> GetAllExamplesAsync()
    {
        return Ok(await service.GetAllExamplesAsync());
    }*/
}