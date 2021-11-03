using ArkanCore.DAL.Common;
using ArkkanCore.DAL.Interfaces;
using ArkkanCore.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace ArkanCore.MVC.Areas.Reports.Controllers
{
    [Area("Reports")]
    public class CoursePaymentsController : Controller
    {
        private CustomDbContext _context;
        private dynamic expObj;
        
        public CoursePaymentsController(CustomDbContext context)
        {
            expObj = new ExpandoObject();
            _context = context;

        }

        public IActionResult Index()
        {
            return View(expObj);
        }

        public IActionResult _list()
        {
            string strSQL = "select coursestudentmas.coursecode gcode ,coursenma ,sum(coursevalue) total ,coursestudentmas.coursecode pk from coursestudentmas,coursemas where coursestudentmas.coursecode = coursemas.coursecode and coursestudentmas.branchcode = coursemas.branchcode   and coursestudentmas.cancelvoucher is null  and coursestudentmas.branchcode = 1 and coursestudentmas.depcode = 1  group by coursestudentmas.coursecode,coursenma ";
            var lstData = _context.coursePaymentsReport.FromSqlRaw(strSQL).ToList();
            expObj.coursePaymentsList = lstData;
            return PartialView(expObj);
        }

    }
}
