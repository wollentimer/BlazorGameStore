using BlazorGameStore.Shared;

namespace BlazorGameStore.Client.Services.BlogService
{
    public class BlogService : IBlogService
    {
        public List<BlogPost> Posts { get; set; } = new List<BlogPost>()
        {
            new BlogPost { Url = "new-tutorial-blazor", Title = "A new blazor tutorial", Description = "This is a new tutorial how to build a blog with Blazor", Content="Lorem ipsum qeqwew wqeww qwe weqwe qwewqewqewqe qqweqweww. Qewewew wqeq w."},
            new BlogPost { Url = "new-tutorial-asp", Title = "A new asp.net core tutorial", Description = "This is a new asp.net core tutorial about building an Api with Asp.net core", Content="Lorem ipsum qeqwew wqeww qwe weqwe qwewqewqewqe qqweqweww. Qewewew wqeq w."}
        };

        public BlogPost GetBlogPostByUrl(string url)
        {
            return Posts.FirstOrDefault(
                p => p.Url.ToLower().Equals(url.ToLower()));
        }

        public List<BlogPost> GetBlogPosts()
        {
            return Posts;
        }
    }
}
