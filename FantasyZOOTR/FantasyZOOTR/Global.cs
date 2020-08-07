using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyZOOTR
{
    public static class Global
    {

        /// <summary>
        /// Keys are names of items. Values are the various point values awarded sequentially for progressively finding more of that item.
        /// </summary>
        public static Dictionary<string, List<double>> values = new Dictionary<string, List<double>>();
    }
}
