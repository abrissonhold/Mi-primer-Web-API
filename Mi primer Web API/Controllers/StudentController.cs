using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Aplication.Interfaces;
using Aplication.Models;

namespace Mi_primer_Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class StudentController : ControllerBase
    {
        private readonly IStudentServices _services;
        public StudentController(IStudentServices services)
        {
            _services = services;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _services.GetAll();
            return new JsonResult(result);
        }
        [HttpPost]
        public async Task<IActionResult>  CreateStudent(CreateStudentRequest request)
        {
            var result = await _services.CreateStudent(request);
            return new JsonResult(result);
        }
    }
}
