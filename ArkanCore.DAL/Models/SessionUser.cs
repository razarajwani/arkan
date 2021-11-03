using System;
using System.Collections.Generic;

#nullable disable

namespace ArkkanCore.DAL.Models
{
    public partial class SessionUser
    {
        public long SessionId { get; set; }
        public int? Usercode { get; set; }
        public string UserName { get; set; }
        public DateTime? Logindate { get; set; }
        public int? Branchcode { get; set; }
        public string UserIp { get; set; }
        public int? UserDel { get; set; }
        public DateTime? TimeDel { get; set; }
        public long? SessionAdd { get; set; }
        public long? SessionEdit { get; set; }
        public int? OldUser { get; set; }
        public long? SessionDel { get; set; }
    }
}
