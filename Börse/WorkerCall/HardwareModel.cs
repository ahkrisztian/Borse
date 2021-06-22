using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Börse.WorkerCall
{
    public class HardwareModel : IHardware
    {
        public string name { get; set; }
        public int power { get; set; }
        public int temp { get; set; }

        public IHardware1 HardwareProcessor { get; set; } = new Hardware();
    }
}
