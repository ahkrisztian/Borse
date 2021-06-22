using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Börse.CoinsCall
{
    public static class LoadCoinList
    {
        public static List<ICoinModel> coinModels()
        {
            var ListofCoins = new CoinList();

            var facade = new CoinFacade(ListofCoins);

            var bitcoin = new CoinModel { name = "BTC" };
            var ethereum = new CoinModel { name = "ETH" };

            List<ICoinModel> models = facade.AddToList(new List<ICoinModel> { bitcoin, ethereum });

            return models;

        }

        public static double StockDollarToEuro(string address)
        {
            return Math.Round(GetStockPrice.GetStat.StatString(address) / Form1.eurodollar, 2);
        }

        public static double StockPrice(string address)
        {
            return GetStockPrice.GetStat.StatString(address);
        }
    }
}

