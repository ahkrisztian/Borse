using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Börse
{
    public static class GetStockPrice
    {
        public static class GetStat
        {
            public static string getHtml(string x)
            {
                try
                {
                    WebRequest request = WebRequest.Create(x);
                    // If required by the server, set the credentials.
                    request.Credentials = CredentialCache.DefaultCredentials;
                    // Get the response.
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    // Display the status.
                    //Console.WriteLine(response.StatusDescription);
                    // Get the stream containing content returned by the server.
                    Stream dataStream = response.GetResponseStream();
                    // Open the stream using a StreamReader for easy access.
                    StreamReader reader = new StreamReader(dataStream);
                    // Read the content.
                    string responseFromServer = reader.ReadToEnd();
                    // Display the content.
                    //Console.WriteLine(responseFromServer);
                    // Cleanup the streams and the response.
                    reader.Close();
                    dataStream.Close();
                    response.Close();
                    return responseFromServer;
                }
                catch
                {
                    return null;

                }
            }


            public static string[] arrayContains(string[] x, string SearchWord)
            {
                List<string> contains = new List<string>();
                for (int i = 0; i < x.Length; i++)
                {
                    if (x[i].Contains(SearchWord))
                    {
                        contains.Add(x[i].ToLower());
                    }
                }
                return contains.ToArray();
            }


            public static string StockName(string Html)
            {
                string htmlRing = getHtml(Html);

                string[] htmlRingArray = htmlRing.Split('\t');

                string[] nums = arrayContains(htmlRingArray, "colspan");

                return nums[0];

            }

            public static double StatString(string Html)
            {
                string htmlRing = getHtml(Html);

                string[] htmlRingArray = htmlRing.Split('\n');

                string[] nums = arrayContains(htmlRingArray, "meta");

                string[] price = arrayContains(nums, "price");

                string purePrice = "";

                foreach (char c in price[1].Replace(" ", string.Empty))
                {
                    if (Char.IsDigit(c) || c == '.')
                    {
                        purePrice += c;
                    }
                }

                try
                {
                    return Convert.ToDouble(purePrice.Replace(".", ","));
                }
                catch
                {
                    throw new Exception("Wrong string-to-double format");
                }

                //char[] stockprice = nums[0].ToCharArray();

                //int i = Array.IndexOf(stockprice, '>');

                //string message = nums[0].Substring(i + 1);

                //return message.Replace('.', ' ').Replace(',', '.').Replace(" ", "");

            }
        }
    }
}
