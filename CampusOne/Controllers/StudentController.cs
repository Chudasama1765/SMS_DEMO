using Application.Features.Student.Services;
using CampusOne.Domain.Entitys.Student;
using Microsoft.AspNetCore.Mvc;

namespace CampusOne.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly StudentServices _studentServices;
        public StudentController(StudentServices studentServices)
        {
            _studentServices = studentServices;
        }

        [HttpGet]
        public async Task<List<StudentEntity>> GetStudentsAsync()
        {
            return await _studentServices.GetStudents();
        }

        [HttpGet("{id}")]
        public StudentEntity GetById(Guid id)
        {
            return _studentServices.GetStudentById(id);
        }
    }
}
