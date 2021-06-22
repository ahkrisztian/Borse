using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Börse
{
    public static class LoadWorkerProcessor
    {
        public static async Task<WorkerModel.Root> LoadWorker(string key, string workername)
        {
            string website = $"https://api.minerstat.com/v2/stats/{ key}/{workername}";

            using (HttpResponseMessage responseMessage = await ApiHelper.ApiClient.GetAsync(website))
            {
                if (responseMessage.IsSuccessStatusCode)
                {
                    WorkerModel.Root worker = await responseMessage.Content.ReadAsAsync<WorkerModel.Root>();

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
