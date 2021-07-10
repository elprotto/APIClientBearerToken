using System;
using System.Threading.Tasks;
using WebApiClient.Services;

namespace WebApiClient
{
    class Program
    {
        static async Task Main(string[] args)
        {

            var jobId = await GetJobIdService.GetJobId();
        }
    }
}
