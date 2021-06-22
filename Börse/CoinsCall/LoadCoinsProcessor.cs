using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Börse
{
    public static class LoadCoinsProcessor
    {
        public static async Task<CoinModel> LoadCoin(string api)
        {
            string website = $"https://api.minerstat.com/v2/coins?list=";
            string url = $"{website}{api}";

            using (HttpResponseMessage responseMessage = await ApiHelper.ApiClient.GetAsync(url))
            {
                try
                {
                    var jsonstring = await responseMessage.Content.ReadAsStringAsync();

                    CoinModel model = JsonConvert.DeserializeObject<CoinModel>(jsonstring.Substring(1, jsonstring.Length - 2));

                    return model;
                }
                catch
                {
                    throw new Exception(responseMessage.ReasonPhrase);
                }


                //if (responseMessage.IsSuccessStatusCode)
                //{
                //    var jsonstring = await responseMessage.Content.ReadAsStringAsync();

                //    CoinModel model = JsonConvert.DeserializeObject<CoinModel>(jsonstring.Substring(1, jsonstring.Length - 2));

                //    return model;
                //}
                //else
                //{
                //    throw new Exception(responseMessage.ReasonPhrase);
                //}
            }
        }
        
    }
}
;