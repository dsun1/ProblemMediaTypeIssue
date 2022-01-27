using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;

namespace ProblemMediaTypeIssue.Controllers;

public class ProblemController : Controller
{
    [HttpGet("problem1")]
    public IActionResult GetProblem1()
    {
        return Problem("Bad things happened.");
    }

    [Produces(MediaTypeNames.Application.Json)]
    [HttpGet("problem2")]
    public IActionResult GetProblem2()
    {
        return Problem("Worse things happened. The media type is wrong!");
    }
}