using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Börse
{
    public static class LoadAllCoinName
    {
        public static async Task<CoinModel> LoadCoin()
        {
            string website = $"https://api.minerstat.com/v2/coins";

            using (HttpResponseMessage responseMessage = await ApiHelper.ApiClient.GetAsync(website))
            {
                if (responseMessage.IsSuccessStatusCode)
                {
                    string jsonstring = await responseMessage.Content.ReadAsStringAsync();

                    string cleanjsonstring = jsonstring.Substring(1, jsonstring.Length - 2);

                    CoinModel model = JsonConvert.DeserializeObject<CoinModel>(cleanjsonstring);

                    return model;
                }
                else
                {
                    throw new Exception(responseMessage.ReasonPhrase);
                }
            }
        }
    }
}
