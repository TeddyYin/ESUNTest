using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.API.F_D0047_61
{
    public class mWeatherElement
    {
        public string elementName { get; set; }

        public string description { get; set; }

        public List<mTime> time { get; set; }
    }
}
