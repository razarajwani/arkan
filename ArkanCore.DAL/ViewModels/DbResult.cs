using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkkanCore.DAL.ViewModels
{
    public class DbResult
    {
        public bool isError { get; set; }
        public string msg { get; set; }

        public object scalerVal { get; set; }

    }
}
