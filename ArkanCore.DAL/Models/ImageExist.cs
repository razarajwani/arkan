using System;
using System.Collections.Generic;

#nullable disable

namespace ArkkanCore.DAL.Models
{
    public partial class ImageExist
    {
        public long? Id { get; set; }
        public int? ImageStatus { get; set; }
        public long? ImageSerial { get; set; }
        public string NewPath { get; set; }
        public string OldPath { get; set; }
        public string Level1 { get; set; }
        public int? ImageTyp { get; set; }
    }
}
