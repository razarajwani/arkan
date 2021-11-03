﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ArkkanCore.DAL.Models
{
    public partial class ModulePermMa
    {
        public int UserCode { get; set; }
        public int ModuleCode { get; set; }
        public int? Branchcode { get; set; }
        public int? UserAdd { get; set; }
        public int? UserEdit { get; set; }
        public DateTime? TimeAdd { get; set; }
        public DateTime? TimeEdit { get; set; }
        public int? OldUser { get; set; }
        public int? UserDel { get; set; }
        public DateTime? TimeDel { get; set; }
        public long? SessionAdd { get; set; }
        public long? SessionEdit { get; set; }
        public long? SessionDel { get; set; }
    }
}
