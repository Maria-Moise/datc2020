using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Tema2.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        // GET: api/Students
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return StudentRepo.Students;
        }

        // GET: api/Students
        [HttpGet("id")]
        public Student GetStudent([FromRoute] int id)
        {
            return StudentRepo.Students.FirstOrDefault(s => s.ID == id);
        }

        // POST: api/Students
        [HttpPost]
        public string Post([FromBody] Student student)
        {
            try
            {
                StudentRepo.Students.Add(student);
                return "S-a adaugat cu succes!";
            }
            catch (System.Exception e)
            {
                return "Eroare: " + e.Message;
                throw;
            }
        }
    }
}
/*
        // PUT: api/Students/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
*/