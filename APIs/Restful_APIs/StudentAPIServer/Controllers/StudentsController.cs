using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using StudentAPIServer.DataSimulator;
using StudentAPIServer.Model;

namespace StudentAPIServer.Controllers
{
    [Route("api/Students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [HttpGet("GetAllStudents")]
        public ActionResult<IEnumerable<Student>> GetStudents()
        {
            return Ok(StudentData.StudentList);
        }
    }
}
