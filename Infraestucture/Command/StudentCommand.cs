using Domain.Entities;
using Infraestucture.Persistence;
using Aplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestucture.Command
{
    public class StudentCommand : IStudentCommand
    {
        private readonly AppDbContext _context;

        public StudentCommand(AppDbContext context)
        {
            _context = context;
        }

        public Task DeleteStudent(int studentId)
        {
            throw new NotImplementedException();
        }

        public async Task InsertStudent(Student student)
        {
            _context.Add(student);
            await _context.SaveChangesAsync();
        }
    }
}