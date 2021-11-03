using System;
using System.Collections.Generic;

#nullable disable

namespace ArkkanCore.DAL.Models
{
    public partial class InboxMsg
    {
        public int InBoxId { get; set; }
        public int FromUserCode { get; set; }
        public int UserGroupCode { get; set; }
        public int ToUserCode { get; set; }
        public string Msg { get; set; }
        public int BranchCode { get; set; }
        public int? Done { get; set; }
        public int? UserAdd { get; set; }
        public int? UserEdit { get; set; }
        public DateTime? TimeAdd { get; set; }
        public DateTime? TimeEdit { get; set; }
        public int? UserDel { get; set; }
        public DateTime? TimeDel { get; set; }
        public long? SessionAdd { get; set; }
        public long? SessionEdit { get; set; }
        public long? SessionDel { get; set; }
    }
}
