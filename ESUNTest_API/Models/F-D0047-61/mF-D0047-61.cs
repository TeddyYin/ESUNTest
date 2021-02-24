using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ESUNTest_API.Models.F_D0047_61
{
    // F-D0047-61
    public class mF_D0047_61
    {
        [Key]
        public Guid guid { get; set; }

        [DisplayName("地點說明")]//欄位名稱
        public string LocationsName { get; set; }
    }
}