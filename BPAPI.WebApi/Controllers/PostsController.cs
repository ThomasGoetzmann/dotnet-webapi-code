using BPAPI.Domain.Posts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging.Abstractions;
using Serilog;

namespace BPAPI.WebApi.Controllers;

[ApiController]
[Route("posts")]
public class PostsController : ControllerBase
{
    private readonly IPostService _posts;
    private readonly ILogger<PostsController> _logger;

    public PostsController(IPostService posts, ILogger<PostsController>? logger = null)
    {
        _posts = posts;
        _logger = logger ?? new NullLogger<PostsController>();
    }
    
    [HttpGet()]
    public async Task<IActionResult> GetPosts()
    {
        _logger.LogInformation("Trying to get posts from an external service");
        var allPosts = await _posts.GetPosts();
        return Ok(allPosts);
    }
}