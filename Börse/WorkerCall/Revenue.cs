using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Börse
{
    public class Revenue
    {
        public WorkerModel.WORKER001 Create(IRevenue revenue)
        {
            WorkerModel.WORKER001 output = new WorkerModel.WORKER001();

            output.revenue.coin = revenue.coin;
            output.revenue.usd_day = revenue.usd_day;
            output.revenue.usd_week = revenue.usd_week;
            output.revenue.usd_month = revenue.usd_week;

            return output;
        }
    }
}
