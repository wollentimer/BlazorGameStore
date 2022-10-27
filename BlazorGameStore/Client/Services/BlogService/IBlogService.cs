using BlazorGameStore.Shared;

namespace BlazorGameStore.Client.Services.BlogService
{
    public interface IBlogService
    {
        Task<List<BlogPost>> GetBlogPosts();

        Task<BlogPost> GetBlogPostByUrl(string url);

        Task<BlogPost> CreateBlogPost(BlogPost request);

    }
}
