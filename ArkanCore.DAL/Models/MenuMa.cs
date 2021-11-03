using System;
using System.Collections.Generic;

#nullable disable

namespace ArkkanCore.DAL.Models
{
    public partial class MenuMa
    {
        public int ModuleCode { get; set; }
        public string Menuvalue { get; set; }
        public string Menutext { get; set; }
        public string Main { get; set; }
        public string Linkpage { get; set; }
        public string Mainsql { get; set; }
        public string Tablename { get; set; }
        public string Pkfield { get; set; }
        public int? Menuorder { get; set; }
        public int? Btnaddview { get; set; }
        public string Orederfield { get; set; }
        public string CapOfForm { get; set; }
        public int? RepId { get; set; }
        public string Parameter1 { get; set; }
        public int? BtnRemove { get; set; }
        public string GroupFnma { get; set; }
        public int? IsReport { get; set; }
        public int? Deleted { get; set; }
        public string LinkAdd { get; set; }
        public string BetweenDate { get; set; }
        public string SumField { get; set; }
        public int? BranchCode { get; set; }
        public int? RecordByPage { get; set; }
        public string DrillDownField { get; set; }
        public string DrillDownCap { get; set; }
        public int? UserAdd { get; set; }
        public int? UserEdit { get; set; }
        public DateTime? TimeAdd { get; set; }
        public DateTime? TimeEdit { get; set; }
        public int? UserDel { get; set; }
        public DateTime? TimeDel { get; set; }
        public long? SessionAdd { get; set; }
        public long? SessionEdit { get; set; }
        public long? SessionDel { get; set; }

        public virtual ModuleMa ModuleCodeNavigation { get; set; }
    }
}
