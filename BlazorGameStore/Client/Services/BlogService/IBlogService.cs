using BlazorGameStore.Shared;

namespace BlazorGameStore.Client.Services.BlogService
{
    public interface IBlogService
    {
        // List<BlogPost> GetBlogPosts();
        Task<List<BlogPost>> GetBlogPosts();

        // BlogPost GetBlogPostByUrl(string url);
        Task<BlogPost> GetBlogPostByUrl(string url);

    }
}
