using System;
using System.Net.Http;
using System.Threading.Tasks;
using WebApiClient.ApiHelper;

namespace WebApiClient.Services
{
    public class GetJobIdService
    {
        private const string resource = "xxxxxx"; // replace with resource number
        private static ApiCustomHelper apiHelper = new ApiCustomHelper();
        public static async Task<string> GetJobId()
        {
            string response = "";
            try
            {
                HttpRequestMessage httpRequestMessage = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri(ApiInfo.url + resource),
                    Headers = {
                        { "Authorization", $"Bearer {ApiInfo.tokenBearer}"},
                        { "ContentType", "text/xml"}
                    }
                };

                using (HttpResponseMessage apiResponse = await apiHelper.apiClient.SendAsync(httpRequestMessage))
                {
                    if (apiResponse.IsSuccessStatusCode)
                    {
                        string answer = await apiResponse.Content.ReadAsStringAsync();
                        Console.WriteLine(answer);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return response;
        }
    }
}
