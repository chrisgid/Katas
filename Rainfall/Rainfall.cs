using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainfall
{
    public class Rainfall
    {
        public static double Mean(string town, string strng)
        {
            // your code
            return 0;
        }

        public static double Variance(string town, string strng)
        {
            // your code
            return 0;
        }

        public static void GetDataForTown(string town, string dataString)
        {
            var split = dataString.Split('\n');
            string townString = null;

            for (int i = 0; i < split.Length; i++)
                if (split[i].StartsWith(town, true, null))
                    townString = split[i];

            if (!string.IsNullOrEmpty(townString))
            {
                townString = townString.Split(':')[1];
                string[] months = townString.Split(',');
            }

        }
    }
}
