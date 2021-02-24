using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.API.F_D0047_61
{
    public class mLocation
    {
        public string locationName { get; set; }

        public string geocode { get; set; }

        public string lat { get; set; }

        public string lon { get; set; }

        public List<mWeatherElement> weatherElement { get; set; }
    }
}
