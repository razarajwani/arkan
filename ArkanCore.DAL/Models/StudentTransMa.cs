using System;
using System.Collections.Generic;

#nullable disable

namespace ArkkanCore.DAL.Models
{
    public partial class StudentTransMa
    {
        public int StudentTransCode { get; set; }
        public string Studentnma { get; set; }
        public int Coursecode { get; set; }
        public int StartDate { get; set; }
        public int Natcode { get; set; }
        public decimal CetificateNo { get; set; }
        public int FromBranch { get; set; }
        public int ToBranch { get; set; }
        public decimal? Idno { get; set; }
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
