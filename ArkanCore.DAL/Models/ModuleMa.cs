using System;
using System.Collections.Generic;

#nullable disable

namespace ArkkanCore.DAL.Models
{
    public partial class ModuleMa
    {
        public ModuleMa()
        {
            MenuMas = new HashSet<MenuMa>();
        }

        public int ModuleCode { get; set; }
        public string ModuleNmA { get; set; }
        public int? MenuOrder { get; set; }
        public int? ModuleOrder { get; set; }
        public int? Deleted { get; set; }
        public int? ParentModule { get; set; }
        public int? UserAdd { get; set; }
        public int? UserEdit { get; set; }
        public DateTime? TimeAdd { get; set; }
        public DateTime? TimeEdit { get; set; }
        public int? UserDel { get; set; }
        public DateTime? TimeDel { get; set; }
        public long? SessionAdd { get; set; }
        public long? SessionEdit { get; set; }
        public long? SessionDel { get; set; }

        public virtual ICollection<MenuMa> MenuMas { get; set; }
    }
}
