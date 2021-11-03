using System;
using System.Collections.Generic;

#nullable disable

namespace ArkkanCore.DAL.Models
{
    public partial class TermsMa
    {
        public int TermsCode { get; set; }
        public int BranchCode { get; set; }
        public string TermsNmA { get; set; }
        public string TermsNmE { get; set; }
        public long? SessionDel { get; set; }
    }
}
