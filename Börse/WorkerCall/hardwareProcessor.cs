using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Börse
{
    public static class hardwareProcessor
    {
        public static async Task<WorkerModel.WORKER001> LoadWorker()
        {
            string website = $"https://api.minerstat.com/v2/stats/2vf4d9k4km86/WORKER001";

            using (HttpResponseMessage responseMessage = await ApiHelper.ApiClient.GetAsync(website))
            {
                if (responseMessage.IsSuccessStatusCode)
                {
                    WorkerModel.WORKER001 worker = await responseMessage.Content.ReadAsAsync<WorkerModel.WORKER001>();

                    return worker;
                }
                else
                {
                    throw new Exception(responseMessage.ReasonPhrase);
                }
            }
        }
    }
}
