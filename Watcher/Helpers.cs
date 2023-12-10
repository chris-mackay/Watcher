using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watcher
{
    public static class Helpers
    {
        public static string ConvertListToCSV(List<string> list)
        {
            string csv = string.Empty;

            StringBuilder sb = new StringBuilder();
            list.ForEach(x => sb.Append($"{x},"));

            csv = sb.ToString().TrimEnd(',');

            return csv;
        }

        public static List<string> ConvertCSVToList(string csv)
        {
            List<string> list = new List<string>();
            string[] line = csv.Split(',');

            foreach (string s in line) { list.Add(s); }

            return list;
        }
    }
}
