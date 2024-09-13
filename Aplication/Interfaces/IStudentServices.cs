using Aplication.Models;
using Aplication.Response;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Interfaces
{
    public interface IStudentServices
    {
        Task<CreateStudentResponse> CreateStudent(CreateStudentRequest request);
        Task<Student> UpdateStudent(int StudentId);
        Task<Student> DeleteStudent(int StudentId);
        Task<Student> GetById(int StudentId);
        Task<List<Student>> GetAll();
 

    }
}
