using System.Threading.Tasks;
using RestSharp;

namespace Parks.Models
{
  class ApiHelper
  {
    public static async Task<string> GetAll()
    {
      RestClient client = new RestClient("http://localhost:5001/api");
      RestRequest request = new RestRequest($"stateandnatparks", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
  }
}