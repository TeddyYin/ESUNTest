using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.API.F_D0047_61
{
    public class mLocations
    {
        public string datasetDescription { get; set; }

        public string locationsName { get; set; }

        public string dataid { get; set; }

        public List<mLocation> location { get; set; }
    }
}
