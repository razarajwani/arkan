using ArkkanCore.DAL.Interfaces;
using ArkkanCore.DAL.Models;
using ArkkanCore.DAL.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace ArkanCore.MVC.Areas.Reg.Controllers
{
    [Authorize]
    [Area("Reg")]
    public class TraineeRegController : Controller
    {
        private IStudentMasService _StudentMasService;
        private INatMasService _NatMasService;

        private dynamic expObj;

        public TraineeRegController(IStudentMasService StudentMasService, INatMasService NatMasService)
        {
            _StudentMasService = StudentMasService;
            _NatMasService = NatMasService;
            expObj = new ExpandoObject();
        }
        public IActionResult Index()
        {
            expObj.natList = _NatMasService.GetAll();
            return View(expObj);
        }



        [HttpPost]
        public ActionResult save(StudentMa postedData)
        {
            DbResult result = new DbResult();

            postedData.UserAdd = 1;
            postedData.TimeAdd =System.DateTime.Now;
            postedData.CompanyCode = 0;

            result.msg = _StudentMasService.Insert(postedData);
            if (result.msg == "")
            {
                result.msg = _StudentMasService.SaveChanges();
            }
            result.isError = (result.msg != "" ? true : false);




            return Json(new { result = result });
        }


        [HttpPost]
        public ActionResult update(StudentMa postedData)
        {
            DbResult result = new DbResult();

            if (ModelState.IsValid)
            {
                //postedData.ModifiedDate = System.DateTime.Now;
                //postedData.ModifiedBy = 1;


                result.msg = _StudentMasService.Update(postedData);
                if (result.msg == "")
                {
                    result.msg = _StudentMasService.SaveChanges();
                }

                result.isError = (result.msg != "" ? true : false);
            }

            return Json(new { result = result });
        }
    }
}
