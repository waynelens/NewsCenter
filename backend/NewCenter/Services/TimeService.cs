using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewCenter.Services
{
    public class TimeService:ITimeService
    {
        private Dictionary<string, string> timeZone = new Dictionary<string, string>()
        {
            { "PDT","-0700"},
            { "PST","-0800" },
            { "UTC","+0000"},
        };

        public string format = "ddd, dd MMM yyyy HH:mm:ss zzz";

        public DateTime parseTimetoUTC(string rawTime)
        {
            string replaceTime = rawTime;
            foreach (string key in timeZone.Keys)
            {
                if (rawTime.Contains(key))
                {
                    replaceTime = rawTime.Replace(key, timeZone[key]);
                }
            }
            return DateTime.Parse(replaceTime).ToUniversalTime();
        }
    }
}
