using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ESUNTest_API.Models.F_D0047_61;
using MySql.Data.Entity;

namespace ESUNTest_API.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    class ESUNTestContext : DbContext
    {
        public DbSet<mF_D0047_61> F_D0047_61 { get; set; }
    }
}