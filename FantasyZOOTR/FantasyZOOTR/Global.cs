using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FantasyZOOTR
{
    public static class Global
    {

        /// <summary>
        /// Keys are names of items. Values are the various point values awarded sequentially for progressively finding more of that item.
        /// </summary>
        public static Dictionary<string, List<double>> itemValues = new Dictionary<string, List<double>>();

        /// <summary>
        /// Keys are names of players. Values are their draft picks.
        /// </summary>
        public static Dictionary<string, List<string>> playerDrafts = new Dictionary<string, List<string>>();

        /// <summary>
        /// Keys are names of players. Values are their draft picks.
        /// </summary>
        public static Dictionary<string, List<Label>> playerLabels = new Dictionary<string, List<Label>>();



    }
}
