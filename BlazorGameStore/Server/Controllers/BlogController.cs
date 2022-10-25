using BlazorGameStore.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorGameStore.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        public List<BlogPost> Posts { get; set; } = new List<BlogPost>()
        {
            new BlogPost { Url = "new-tutorial-blazor", Title = "A new blazor tutorial", Description = "This is a new tutorial how to build a blog with Blazor", Content="Lorem ipsum qeqwew wqeww qwe weqwe qwewqewqewqe qqweqweww. Qewewew wqeq w."},
            new BlogPost { Url = "new-tutorial-asp", Title = "A new asp.net core tutorial", Description = "This is a new asp.net core tutorial about building an Api with Asp.net core", Content="Lorem ipsum qeqwew wqeww qwe weqwe qwewqewqewqe qqweqweww. Qewewew wqeq w."}
        };


        [HttpGet]
        public ActionResult<List<BlogPost>> GetAllBlogPosts()
        {
            return Ok(Posts);
        }

        [HttpGet("{url}")]
        public ActionResult<BlogPost> GetBlogPostsById(string url)
        {
            var post = Posts.FirstOrDefault(p => p.Url.ToLower().Equals(url.ToLower()));
            if (post == null)
            {
                return NotFound();
            }

            return Ok(post);
        }

    }
}
