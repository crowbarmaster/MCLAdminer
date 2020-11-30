using System.Collections.Generic;

namespace MCL_Adminer
{
    public class Reports
    {
        public string userID;
        public string date;
        public Dictionary<string, Dictionary<string, Dictionary<string, string[]>>> data = new Dictionary<string, Dictionary<string, Dictionary<string, string[]>>>();

        public void LoadAll()
        {
            List<string[]> query = new SQLHandler().Select("records", new string[] { "*" }, null);
            foreach (string[] rpt in query)
            {
                Reports reports = new Reports();
                reports.userID = rpt[1];
                reports.date = rpt[2];
                string dataStr = rpt[3].Substring(0, rpt[3].Length);
                if (!reports.data.ContainsKey(rpt[1]))
                {
                    reports.data.Add(rpt[1], new Dictionary<string, Dictionary<string, string[]>>());
                }
                if (!reports.data[rpt[1]].ContainsKey(rpt[2]))
                {
                    reports.data[rpt[1]].Add(rpt[2], new Dictionary<string, string[]>());
                }
                foreach (string expand in dataStr.Split('>'))
                {
                    string[] explode = expand.Split(';');
                    reports.data[rpt[1]][rpt[2]].Add(explode[0], explode);
                }
                Globals.RptList.Add(reports);
            }
        }

        public string MakeTwo(int input)
        {
            if (input < 10)
            {
                return "0" + input.ToString();
            }
            return input.ToString();
        }

        public string CharToBool(char input)
        {
            if (input == '0')
            {
                return "No";
            }
            return "Yes";
        }
    }
}
