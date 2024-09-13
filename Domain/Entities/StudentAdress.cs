using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class StudentAdress
    {
        public int StudentAdressId { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public int AdressOfStudentId { get; set; }
        public Student Student { get; set; }
    }
}
