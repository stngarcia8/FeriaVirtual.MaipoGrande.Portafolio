using FeriaVirtual.Api.Local;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace LocalApi.Test.Users
{
    public class QueryUserControllerTest
    {

        private readonly TestServer _server;
        private readonly HttpClient _client;


        public QueryUserControllerTest()
        {
            _server = new TestServer(new WebHostBuilder()
                .UseStartup<Startup>());
            _client = _server.CreateClient();
        }


        [Fact]
        public async Task GivenTestUserControllerQuery_WhenCountUsers_ThenReturnNotAEmptyValue()
        {
            //arrange
            var response = await _client.GetAsync("api/users/count");
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            //assert
            Assert.False(string.IsNullOrWhiteSpace(responseString));
        }


        [Fact]
        public async Task GivenTestUserControllerQuery_WhenListAllUsers_ThenReturnCode200()
        {
            //arrange
            var response = await _client.GetAsync("api/users/all/0");
            response.EnsureSuccessStatusCode();
            HttpStatusCode responseCode = response.StatusCode;
            //assert
            Assert.Equal(HttpStatusCode.OK, responseCode);
        }


        [Fact]
        public async Task GivenTestUserControllerQuery_WhenListAnUser_ThenReturnCode200()
        {
            //arrange
            var response = await _client.GetAsync("api/users/ac9ce2f8-08e0-d8ab-d8dd-00b100bc0019");
            response.EnsureSuccessStatusCode();
            HttpStatusCode responseCode = response.StatusCode;
            //assert
            Assert.Equal(HttpStatusCode.OK, responseCode);
        }


    }
}
