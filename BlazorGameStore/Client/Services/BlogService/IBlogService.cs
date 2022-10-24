using BlazorGameStore.Shared;

namespace BlazorGameStore.Client.Services.BlogService
{
    public interface IBlogService
    {
        List<BlogPost> GetBlogPosts();

        BlogPost GetBlogPostByUrl(string url);

    }
}
