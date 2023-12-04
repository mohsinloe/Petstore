using Newtonsoft.Json;
using PetstoreAPI.DTO;

namespace PetstoreAPI
{
    public class Program
    {
        public static string baseUrl = "https://petstore.swagger.io/v2/pet/findByStatus?status=available";
        public static async Task<List<Pet>> GetAvailablePets() 
        {
            List<Pet> pets = new List<Pet>();

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage httpResponse = await client.GetAsync(baseUrl);

                if (httpResponse.IsSuccessStatusCode)
                {
                    string responseBody = await httpResponse.Content.ReadAsStringAsync();

                    pets = JsonConvert.DeserializeObject<List<Pet>>(responseBody);
                }
            }
            return pets;
        }
    }
}