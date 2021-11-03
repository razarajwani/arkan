using System;
using System.Collections.Generic;

#nullable disable

namespace ArkkanCore.DAL.Models
{
    public partial class TrainingRecharg
    {
        public int TrainigRechargeId { get; set; }
        public int BranchCode { get; set; }
        public int UserCode { get; set; }
        public int RechargeDate { get; set; }
        public int RechargeValue { get; set; }
        public int TotalVoucher { get; set; }
        public string TransInfo { get; set; }
        public string ImagePath { get; set; }
        public bool? Post { get; set; }
        public string Note { get; set; }
        public int? Postdate { get; set; }
        public int? UserPost { get; set; }
        public DateTime? TimeEdit { get; set; }
        public int? UserEdit { get; set; }
    }
}
