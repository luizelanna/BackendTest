using BookService;
using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace BookServiceTests.Controllers
{
    public class BooksControllerTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        protected readonly HttpClient _httpClient;

        private readonly WebApplicationFactory<Startup> _factory;

        public BooksControllerTests(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Theory]
        [InlineData("/api/books")]
        public async Task GetTest(string url)
        {
            var clientOptions = new WebApplicationFactoryClientOptions();
            clientOptions.AllowAutoRedirect = true;
            clientOptions.BaseAddress = new Uri("https://localhost:34999");
            clientOptions.HandleCookies = true;
            clientOptions.MaxAutomaticRedirections = 7;

            var client = _factory.CreateClient(clientOptions);

            var response = await client.GetAsync(url);

            response.EnsureSuccessStatusCode();

        }

        [Theory]
        [InlineData("Journey")]
        [InlineData("Luiz")]
        public async Task GetLivrosTest(string type)
        {
            var clientOptions = new WebApplicationFactoryClientOptions();
            clientOptions.AllowAutoRedirect = true;
            clientOptions.BaseAddress = new Uri("https://localhost:34999");
            clientOptions.HandleCookies = true;
            clientOptions.MaxAutomaticRedirections = 7;

            var client = _factory.CreateClient(clientOptions);

            var response = await client.GetAsync("/api/books/buscar/" + type);
            response.EnsureSuccessStatusCode();
        }

        [Theory]
        [InlineData("1")]
        [InlineData("5")]
        [InlineData("6")]
        public async Task GetFreteTest(string livroId)
        {
            var clientOptions = new WebApplicationFactoryClientOptions();
            clientOptions.AllowAutoRedirect = true;
            clientOptions.BaseAddress = new Uri("https://localhost:34999");
            clientOptions.HandleCookies = true;
            clientOptions.MaxAutomaticRedirections = 7;

            var client = _factory.CreateClient(clientOptions);

            var response = await client.GetAsync("/api/books/frete/" + livroId);
            response.EnsureSuccessStatusCode();
        }
    }
}
