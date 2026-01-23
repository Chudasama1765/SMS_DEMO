<<<<<<< HEAD
﻿using System;
=======
﻿using Application.Interfaces.IRepositories;
using CampusOne.Domain.Entitys.Student;
using Infrastructure.DbContexts;
using Microsoft.EntityFrameworkCore;
using System;
>>>>>>> Devlopement
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Implemantation.Repositories
{
<<<<<<< HEAD
    internal class StudentRepository
    {
=======
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentDbContext _context;
        public StudentRepository(StudentDbContext context)
        {
            _context = context;
        }

        public async Task<List<StudentEntity>> GetAllasync()
        {
           return await _context.Student.ToListAsync();
        }

        public StudentEntity GetById(Guid id) => _context.Student.Find(id);
>>>>>>> Devlopement
    }
}
