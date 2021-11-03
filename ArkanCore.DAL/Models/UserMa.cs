using System;
using System.Collections.Generic;

#nullable disable

namespace ArkkanCore.DAL.Models
{
    public partial class UserMa
    {
        public int UserCode { get; set; }
        public int Branchcode { get; set; }
        public string Username { get; set; }
        public int UsergroupCode { get; set; }
        public string Password { get; set; }
        public int? EmpCode { get; set; }
        public int UserTypeCode { get; set; }
        public int? HospitalCode { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public int? DepCode { get; set; }
        public int? UserAdd { get; set; }
        public int? UserEdit { get; set; }
        public DateTime? TimeAdd { get; set; }
        public DateTime? TimeEdit { get; set; }
        public int? OldUser { get; set; }
        public int? UserDel { get; set; }
        public DateTime? TimeDel { get; set; }
        public long? SessionAdd { get; set; }
        public long? SessionEdit { get; set; }
        public int? Usercode2 { get; set; }
        public int? Usercode3 { get; set; }
        public int? Active { get; set; }
        public long? SessionDel { get; set; }
        public int? VoucherBal { get; set; }

        public virtual BranchMa BranchcodeNavigation { get; set; }
        public virtual EmpMa EmpMa { get; set; }
    }
}
