using System;
using System.Collections.Generic;

#nullable disable

namespace ArkkanCore.DAL.Models
{
    public partial class AllReleation
    {
        public string MasterTable { get; set; }
        public string Constraints { get; set; }
    }
}
