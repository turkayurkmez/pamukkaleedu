using introduceAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace introduceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {

        private List<Student> students = new List<Student>
        {
            new Student{ Id=1, Name="Çağrı", OgrenciNo="20171001", Program="Bilgisayar Müh.", State="Mezun"},
            new Student{ Id=2, Name="Türkay", OgrenciNo="20210001", Program="Bilgisayar Müh.", State="Öğrenci"},
            new Student{ Id=3, Name="Cüneyt", OgrenciNo="20141002", Program="Gıda Müh.", State="Öğrenci"},


        };
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            return Ok(students);
        }
        [HttpGet("{id}")]
        public IActionResult GetStudentById(int id)
        {
            var student = students.FirstOrDefault(stu => stu.Id == id);
            if (student != null)
            {
                return Ok(student);
            }
            return NotFound(new { message = $"{id} id'li öğrenci bulunamadı" });

        }
        [HttpGet("Search/{name}")]
        public IActionResult SearchStudent(string name)
        {
            var result = students.Where(s => s.Name.Contains(name, StringComparison.OrdinalIgnoreCase));
            if (result != null && result.Count()>0)
            {
                return Ok(result);
            }
            return NotFound(new { message = $"{name} isimli öğrenci bulunamadı" });
        }
        [HttpPost]
        public IActionResult AddStudent([FromBody]Student student)
        {
            if (ModelState.IsValid)
            {
                students.Add(student);
                student.Id = students.Count;
                return CreatedAtAction(nameof(GetStudentById), new { id = student.Id }, null);
            }
            return BadRequest(ModelState);
        }


    }
}
