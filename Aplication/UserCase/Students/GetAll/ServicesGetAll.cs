using Aplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Aplication.UserCase.Students.GetAll
{
    public class ServicesGetAll : IServicesGetAll
    {
        public object GetAll()
        {
            return new { name = "string"};
        }
    }
}
