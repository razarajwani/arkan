using System;
using System.Collections.Generic;

#nullable disable

namespace ArkkanCore.DAL.Models
{
    public partial class HealthCard
    {
        public int? StudentCode { get; set; }
        public int CertificateHcode { get; set; }
        public int? CertificateDate { get; set; }
        public int BranchCode { get; set; }
        public int? HospitalCode { get; set; }
        public string CardNo { get; set; }
        public int? CertExpire { get; set; }
        public int? HealthResultCode { get; set; }
        public string StudentNmA { get; set; }
        public string Gender { get; set; }
        public string Idno { get; set; }
        public string IdType { get; set; }
    }
}
