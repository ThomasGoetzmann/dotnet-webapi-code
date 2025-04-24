using BPAPI.Domain.Posts;
using Microsoft.AspNetCore.Mvc;

namespace BPAPI.WebApi.Controllers;

[ApiController]
[Route("posts")]
public class PostsController(IPostService posts) : ControllerBase
{
    [HttpGet()]
    public async Task<IActionResult> GetPosts()
    {
        var allPosts = await posts.GetPosts();
        return Ok(allPosts);
    }
    
}