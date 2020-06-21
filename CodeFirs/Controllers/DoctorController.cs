using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeFirs.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirs.Controllers
{
    [Route("api/doctor")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        public MyDBContext _myDBContext;

        public DoctorController (MyDBContext myDBContext)
        {
            _myDBContext = myDBContext;
        }

        [HttpGet]
        public IActionResult GetDoctor()
        {
            return Ok(_myDBContext.Doctor.ToList());
        }

        [HttpPut]
        public IActionResult UpdateDoctor()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult AddDoctor()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteDoctor()
        {
            return Ok();
        }
    }
}