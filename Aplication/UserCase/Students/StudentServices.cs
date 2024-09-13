using Aplication.Interfaces;
using Aplication.Models;
using Aplication.Response;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.UserCase.Students
{
    public class StudentServices : IStudentServices
    {
        private readonly IStudentCommand _command;
        private readonly IStudentQuerys _querys;
        public StudentServices(IStudentCommand command, IStudentQuerys query)
        {
            _command = command;
            _querys = query;
        }

        public async Task<CreateStudentResponse> CreateStudent(CreateStudentRequest request)
        {
            var student = new Student
            {
                Name = request.StudentName,
                Adress = new StudentAdress
                {
                    Adress = request.Adress,
                    City = request.City,
                    Country = request.Country,
                    State = request.State,
                }
            };
            await _command.InsertStudent(student);
            var studentresponse = new CreateStudentResponse
            {
               Name = student.Name,
               StudentId = student.StudentId,
               Adress = new CreateStudentAdressResponse
               {
                   Adress = student.Adress.Adress,
                   AdressOfStudentId = student.Adress.AdressOfStudentId,
                   City = student.Adress.City,
                   Country = student.Adress.Country,
                   State = student.Adress.State,
               }
            };
            return studentresponse;
        }

        public Task<Student> DeleteStudent(int StudentId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Student>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Student> GetById(int StudentId)
        {
            throw new NotImplementedException();
        }

        public Task<Student> UpdateStudent(int StudentId)
        {
            throw new NotImplementedException();
        }
    }
}
