using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Börse
{
    public class CoinList
    {
        public List<ICoinModel> _coinnames;

        public CoinList()
        {
            _coinnames = new List<ICoinModel>();
        }

        public void AddToCoinlist(ICoinModel model)
        {
            _coinnames.Add(model);
        }

        public List<ICoinModel> ListofCoinNames()
        {
            return _coinnames;
        }
    }
}
