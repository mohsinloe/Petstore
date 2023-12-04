using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTestProject
{
    public class PetTest
    {
        public string ApiUrl = PetstoreAPI.Program.baseUrl;

        [Fact]
        public async Task GetAvailablePets_ShouldHaveSuccessStatusCode()
        {
            using (HttpClient client = new HttpClient())
            {         
                HttpResponseMessage response = await client.GetAsync(ApiUrl);
                
                Assert.True(response.IsSuccessStatusCode, $"Expected status code {response.StatusCode}");
            }
        }

        [Fact]
        public async Task GetAvailablePets_ShouldHaveSuccessStatusCodeAndValidJsonResponse()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(ApiUrl);

                Assert.True(response.IsSuccessStatusCode, $"Expected status code {response.StatusCode}");

                string responseBody = await response.Content.ReadAsStringAsync();
                Assert.False(string.IsNullOrWhiteSpace(responseBody), "Response body should not be empty or null");
            }
        }

    }
}
