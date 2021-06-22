using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Börse
{
    public static class CurrentCulture
    {
        public static string Euro(double usd)
        {
            var cultureInfo = CultureInfo.GetCultureInfo("fr-FR");
            return String.Format(cultureInfo, "{0:C}", usd/Form1.eurodollar);
        }
    }
}
