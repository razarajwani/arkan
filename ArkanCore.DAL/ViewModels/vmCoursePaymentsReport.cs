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
    public class vmCoursePaymentsReport
    {
        public int gcode { get; set; }
        public string coursenma { get; set; }
        public double total { get; set; }
        [Key]
        public int pk { get; set; }
    }
}
