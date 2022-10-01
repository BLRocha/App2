using App2.Context;
using App2.Models;
using App2.Models.Repositores;
using Microsoft.AspNetCore.Mvc;

namespace App2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiController : ControllerBase
    {
        protected readonly EmployeesRepositore _employerRepo;

        public ApiController(ContextDb context)
        {
            _employerRepo = new EmployeesRepositore(context);
        }
        [HttpGet]
        public string index()
        {
            
            return "123";
        }

        [HttpGet("employees")]
        public async Task<IList<EmployeesModel>> employes()
        {
            return await _employerRepo.GetEmployes();
        }
    }
}
