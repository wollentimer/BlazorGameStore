using BlazorGameStore.Shared;
using System;
using System.Net.Http.Json;

namespace BlazorGameStore.Client.Services.BlogService
{
    public class BlogService : IBlogService
    {
        private readonly HttpClient _httpClient;

        public BlogService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<BlogPost> GetBlogPostByUrl(string url)
        {
            var result = await _httpClient.GetAsync($"api/Blog/{url}");
            if (result.StatusCode != System.Net.HttpStatusCode.OK)
            {
                var message = await result.Content.ReadAsStringAsync();
                Console.WriteLine(message);
                return new BlogPost { Title = message };
            }
            else
            {
                return await result.Content.ReadFromJsonAsync<BlogPost>();
            }
        }

        public async Task<List<BlogPost>> GetBlogPosts()
        {
            return await _httpClient.GetFromJsonAsync<List<BlogPost>>($"/api/Blog");
        }
    }
}
