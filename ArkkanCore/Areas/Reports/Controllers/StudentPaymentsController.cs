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
    public class StudentPaymentsController : Controller
    {
        private CustomDbContext _context;
        private dynamic expObj;
        
        public StudentPaymentsController(CustomDbContext context)
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
            string strSQL = "select voucherno, dbo.dateof(coursedate) gdate,idno,studentnma ,natnma,coursenma,companymas.companynma,courselangnma,levelnma,courseno,coursevalue value  ,case isnull(cancelvoucher,0) when 1 then 'ملغى' else null end status,coursestudentmas.companynma companynma2  , coursedate pk      from coursestudentmas,studentmas left join companymas on companymas.companycode = studentmas.studentcode  ,coursemas,coursemovemas,courselangmas,levelmas,natmas     where coursestudentmas.studentcode = studentmas.studentcode and  coursestudentmas.branchcode = studentmas.branchcode  and coursestudentmas.coursecode  = coursemas.coursecode  and coursestudentmas.branchcode = coursemas.branchcode    and coursestudentmas.coursemovecode = coursemovemas.coursemovecode  and coursestudentmas.branchcode = coursemovemas.branchcode     and coursemovemas.courselangcode = courselangmas.courselangcode and coursemovemas.levelcode = levelmas.levelcode and coursestudentmas.branchcode = 1    and natmas.natcode = studentmas.natcode  and  coursestudentmas.depcode  = 1 ";
            var lstData = _context.studentPaymentsReport.FromSqlRaw(strSQL).ToList();
            expObj.StudentPaymentsList = lstData;
            return PartialView(expObj);
        }

    }
}
