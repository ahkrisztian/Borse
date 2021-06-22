using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Börse.LoginData
{
    public static class LoginValidator
    {
        public static async Task LoadWorker(string key, string workername)
        {
            string website = $"https://api.minerstat.com/v2/stats/{ key}/{workername}";

            using (HttpResponseMessage responseMessage = await ApiHelper.ApiClient.GetAsync(website))
            {
                if (responseMessage.IsSuccessStatusCode == true)
                {

                    Form1.key = key;
                    Form1.workername = workername;

                    Form1 form = new Form1();
                    form.Show();
                }
                else
                {
                    throw new Exception(responseMessage.ReasonPhrase);
                }
            }
        }
    }
}
