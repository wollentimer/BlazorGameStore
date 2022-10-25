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
            //var response = await _httpClient.GetFromJsonAsync<BlogPost>($"https://localhost:7001/api/Blog/{url}");
            
            var response = await _httpClient.GetFromJsonAsync<BlogPost>($"/api/Blog/{url}");
            return response;
        }

        public async Task<List<BlogPost>> GetBlogPosts()
        {
            //var response = await _httpClient.GetFromJsonAsync<List<BlogPost>>("https://localhost:7001/api/Blog");
            var response = await _httpClient.GetFromJsonAsync<List<BlogPost>>($"/api/Blog");

            return response;
        }
    }
}
