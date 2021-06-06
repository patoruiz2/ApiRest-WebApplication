using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ModelApi;
using RepoStudent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRest_WebApplication.Controllers
{
    [ApiController]
    [Route("api/student")]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            Rstudent rStudent = new Rstudent();
            return Ok(rStudent.ReturnStudent());
        }

        [HttpGet("{dni}")]
        public IActionResult Get(int dni)
        {
            Rstudent rStudent = new Rstudent();

            var studentDni = rStudent.ReturnStudentDni(dni);

            if(studentDni == null)
            {
                var notF = NotFound(" student with DNI " + dni.ToString() + "not exist");
                return notF;
            }
            return Ok(studentDni);
        }

        [HttpPost("add")]
        public IActionResult AddStudent(Student newStudent)
        {
            Rstudent repStudent = new Rstudent();
            repStudent.Add(newStudent);

            return CreatedAtAction(nameof(AddStudent), newStudent);
        }

    }
}