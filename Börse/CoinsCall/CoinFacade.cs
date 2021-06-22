using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Börse
{
    public  class CoinFacade
    {
        public readonly CoinList _coinlist;

        public CoinFacade(CoinList coinList)
        {
            _coinlist = coinList;
        }

        public List<ICoinModel> AddToList(List<ICoinModel> models)
        {
            foreach (var model in models)
            {
                _coinlist.AddToCoinlist(model);
            }

            return _coinlist.ListofCoinNames();
        }
    }
}
