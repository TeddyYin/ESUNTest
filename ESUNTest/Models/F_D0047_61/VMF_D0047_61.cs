using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ViewModels.API.F_D0047_61;

namespace ESUNTest.Models.F_D0047_61
{
    public class VMF_D0047_61
    {
        private mF_D0047_61 oData;

        public VMF_D0047_61(mF_D0047_61 oData)
        {
            sDatasetDescription = oData.records.locations.First().datasetDescription;
            sLocationsName = oData.records.locations.First().locationsName;
            sLocationName = oData.records.locations.First().location.First().locationName;
            sDescription = oData.records.locations.First().location.First().weatherElement.First().description;

            var oTemp = oData.records.locations.First().location.First().weatherElement.First().time;
            lTimes = new List<VMTime>();

            for (int i = 0; i < oTemp.Count; i++)
            {
                VMTime time = new VMTime();

                time.sDataTime = oTemp[i].dataTime;
                time.sValue = oTemp[i].elementValue.First().value;

                lTimes.Add(time);
            }
        }

        public string sDatasetDescription { get; set; }

        public string sLocationsName { get; set; }

        public string sLocationName { get; set; }

        public string sDescription { get; set; }

        public List<VMTime> lTimes { get; set; }
    }
}