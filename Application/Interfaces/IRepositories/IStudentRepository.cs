<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IRepositories
{
    internal class IStudentRepository
    {
=======
﻿using CampusOne.Domain.Entitys.Student;

namespace Application.Interfaces.IRepositories
{
    public interface IStudentRepository
    {
        Task<List<StudentEntity>> GetAllasync();

        StudentEntity GetById(Guid id);
>>>>>>> Devlopement
    }
}
