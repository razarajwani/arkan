using System;
using System.Collections.Generic;

#nullable disable

namespace ArkkanCore.DAL.Models
{
    public partial class HistoryDataMa
    {
        public int HistorySerial { get; set; }
        public string TableName { get; set; }
        public DateTime? Movetime { get; set; }
        public int? Movetype { get; set; }
        public int? BranchCode { get; set; }
        public int? MoveCode { get; set; }
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
