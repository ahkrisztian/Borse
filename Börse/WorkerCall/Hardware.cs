using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Börse
{
    public class Hardware : IHardware1
    {
        public WorkerModel.Hardware Create(IHardware hardware)
        {
            WorkerModel.Hardware hardware1 = new WorkerModel.Hardware();

            hardware1.name = hardware.name;
            hardware1.temp = hardware.temp;
            hardware1.power = hardware.power;

            return hardware1;
        }
    }
}
