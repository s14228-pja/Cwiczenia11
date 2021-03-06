﻿using System;
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
        public IActionResult UpdateDoctor([FromBody] Doctor doctor)
        {
            var d1 = _myDBContext.Doctor.Find(doctor.IdDoctor);
            d1.LastName = doctor.LastName;
            d1.FirstName = doctor.FirstName;
            d1.Email = doctor.Email;
            _myDBContext.SaveChanges();
            return Ok();
        }

        [HttpPost]
        public IActionResult AddDoctor([FromBody] Doctor doctor)
        {
            _myDBContext.Doctor.Add(doctor);
            _myDBContext.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}"]
        public IActionResult DeleteDoctor([FromRoute]int id)
        {
            var d = new Doctor
            {
                IdDoctor = id
            }; 
            
            _myDBContext.Attach(d);
            _myDBContext.Remove(d);
            _myDBContext.SaveChanges();
            return Ok();
        }
    }
}