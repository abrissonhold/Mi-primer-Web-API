﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Response
{
    public class CreateStudentResponse
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public CreateStudentAdressResponse Adress { get; set; }

    }
    public class CreateStudentAdressResponse
    {
        public int StudentAdressId { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public int AdressOfStudentId { get; set; }
    }
}
