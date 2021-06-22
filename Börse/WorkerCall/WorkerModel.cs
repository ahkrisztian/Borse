using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Börse
{
    public class WorkerModel
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class Os
        {
            public string status { get; set; }
            public int sync { get; set; }
            public string uptime { get; set; }
            public int cpu_temp { get; set; }
            public int cpu_load { get; set; }
            public double freespace { get; set; }
            public int freemem { get; set; }
            public string localip { get; set; }
        }

        public class Info
        {
            public string type { get; set; }
            public string system { get; set; }
            public string status { get; set; }
            public int inactive { get; set; }
            public string status_reason { get; set; }
            public string status_cpu { get; set; }
            public string uptime { get; set; }
            public int sync { get; set; }
            public string time { get; set; }
            public int note { get; set; }
            public int profit_switch { get; set; }
            public string name { get; set; }
            public string version { get; set; }
            public string groups { get; set; }
            public string cmd { get; set; }
            public int electricity { get; set; }
            public int hot { get; set; }
            public int veryHot { get; set; }
            public int devices { get; set; }
            public int consumption { get; set; }
            public Os os { get; set; }
        }

        public class Hardware
        {
            public string name { get; set; }
            public int temp { get; set; }
            public int fan { get; set; }
            public int power { get; set; }
            public int powerMin { get; set; }
            public int powerMax { get; set; }
            public int powerStock { get; set; }
            public double speed { get; set; }
            public string bus { get; set; }
            public int core { get; set; }
            public int coreMax { get; set; }
            public int memory { get; set; }
            public int memoryMax { get; set; }
            public int load { get; set; }
            //public IHardware1 HardwareProcessor { get; set; } = new Hardware();

        }

        public class Revenue : IRevenue
        {
            public double usd_day { get; set; }
            public int usd_day_dual { get; set; }
            public int usd_day_cpu { get; set; }
            public double usd_week { get; set; }
            public double usd_month { get; set; }
            public int usd_month_dual { get; set; }
            public int usd_month_cpu { get; set; }
            public double btc_day { get; set; }
            public double btc_week { get; set; }
            public double btc_month { get; set; }
            public double coin { get; set; }
            public int coin_dual { get; set; }
            public int coin_cpu { get; set; }
            public double cprice { get; set; }
            public int cprice_dual { get; set; }
            public int cprice_cpu { get; set; }
        }

        public class Hashrate
        {
            public double hashrate { get; set; }
            public string hashrate_unit { get; set; }
            public int hashrate_dual { get; set; }
            public string hashrate_unit_dual { get; set; }
            public int hashrate_cpu { get; set; }
            public string hashrate_unit_cpu { get; set; }
        }

        public class Shares
        {
            public int accepted_share { get; set; }
            public int accepted_share_dual { get; set; }
            public int rejected_share { get; set; }
            public int rejected_share_dual { get; set; }
            public int accepted_share_cpu { get; set; }
            public int rejected_share_cpu { get; set; }
        }

        public class Mining
        {
            public string client { get; set; }
            public string client_version { get; set; }
            public string client_cpu { get; set; }
            public string client_cpu_version { get; set; }
            public string crypto { get; set; }
            public string crypto_dual { get; set; }
            public string crypto_cpu { get; set; }
            public string pool { get; set; }
            public string pool_dual { get; set; }
            public string pool_cpu { get; set; }
            public Hashrate hashrate { get; set; }
            public Shares shares { get; set; }
        }

        public class WORKER001
        {
            public Info info { get; set; }
            public List<Hardware> hardware { get; set; }
            public Revenue revenue { get; set; }
            public Mining mining { get; set; }
        }

        public class Root
        {
            public WORKER001 WORKER001 { get; set; }
        }


    }
}
