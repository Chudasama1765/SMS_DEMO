using Application.Interfaces.IRepositories;
using CampusOne.Domain.Entitys.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Student.Services
{
    public class StudentServices
    {
        private readonly IStudentRepository _studentRepository;

        public StudentServices(IStudentRepository studentRepository)
        {
            _studentRepository= studentRepository;
        }

        public async Task<List<StudentEntity>> GetStudents()
        {
            return await _studentRepository.GetAllasync();
        }
        public StudentEntity GetStudentById(Guid id) => _studentRepository.GetById(id);
    }
}
