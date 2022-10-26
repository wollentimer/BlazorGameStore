using BlazorGameStore.Server.Data;
using BlazorGameStore.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorGameStore.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly DataContext _context;

        public BlogController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<BlogPost>> GetAllBlogPosts()
        {
            return Ok(_context.BlogPosts);
        }

        [HttpGet("{url}")]
        public ActionResult<BlogPost> GetBlogPostsById(string url)
        {
            var post = _context.BlogPosts.FirstOrDefault(p => p.Url.ToLower().Equals(url.ToLower()));
            if (post == null)
            {
                return NotFound("This post does not exist.");
            }

            return Ok(post);
        }

    }
}
