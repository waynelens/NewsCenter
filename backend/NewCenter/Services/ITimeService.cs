using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewCenter.Services
{
    interface ITimeService
    {
        public DateTime parseTimetoUTC(string rawTime);
    }
}
