using ArkkanCore.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkkanCore.DAL.ViewModels
{
    public class vmStudentPaymentsReport
    {
        public Int32? voucherno { get; set; }
        public string gdate { get; set; }
        public string idno { get; set; }
        public string studentnma { get; set; }
        public string natnma { get; set; }
        public string coursenma { get; set; }
        public string companynma { get; set; }
        public string courselangnma { get; set; }
        public string levelnma { get; set; }
        public int courseno { get; set; }
        public double value { get; set; }
        public string status { get; set; }
        public string companynma2 { get; set; }
        [Key]
        public int pk { get; set; }
    }
}
