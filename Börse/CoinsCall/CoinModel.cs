using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Börse
{
    public class CoinModel : ICoinModel
    {
        public string id { get; set; }
        public string coin { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string algorithm { get; set; }
        public double network_hashrate { get; set; }
        public long difficulty { get; set; }
        public double reward { get; set; }
        public string reward_unit { get; set; }
        public double reward_block { get; set; }
        public double price { get; set; }
        public double volume { get; set; }
        public int updated { get; set; }

    }
}
