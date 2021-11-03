using System;
using System.Collections.Generic;

#nullable disable

namespace ArkkanCore.DAL.Models
{
    public partial class StudImage
    {
        public long Id { get; set; }
        public string ImagePath { get; set; }
        public int? StudentCode { get; set; }
        public int? Typ { get; set; }
        public int? IsActive { get; set; }
        public int? ImageStatus { get; set; }
        public string OldPath { get; set; }
        public string ImagePath2 { get; set; }
        public long? ImageSerial { get; set; }
        public string Path2018 { get; set; }
    }
}
