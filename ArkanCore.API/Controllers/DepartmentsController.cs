using ArkkanCore.DAL.Interfaces;
using ArkkanCore.DAL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArkanCore.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        protected IDepMasService DepMasService { get; }

        public DepartmentsController(IDepMasService depMasService)
        {
            DepMasService = depMasService;
        }



        [HttpGet]
        public IEnumerable<DepMa> Get()
        {
            return DepMasService.GetAll();
        }
    }
}
