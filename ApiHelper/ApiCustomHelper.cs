using System;
using System.Net.Http;

namespace WebApiClient.ApiHelper
{
    public class ApiCustomHelper
    {
        public HttpClient apiClient { get; set; }
        public ApiCustomHelper()
        {
            this.apiClient = new HttpClient();
            this.apiClient.Timeout = TimeSpan.FromMinutes(30);
            this.apiClient.DefaultRequestHeaders.
                UserAgent.
                ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:61.0) Gecko/20100101 Firefox/61.0");
            this.apiClient.DefaultRequestHeaders.Accept.Clear();

            this.apiClient.DefaultRequestHeaders.Accept.Add(
                    new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json")
                ) ;

        }
    }
}
