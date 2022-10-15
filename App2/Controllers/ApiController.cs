using System.Linq;
using App2.Models;
using System.Data;
using App2.Context;
using App2.Models.Repositores;
using Microsoft.AspNetCore.Mvc;

namespace App2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiController : ControllerBase
    {
        protected readonly EmployeesRepositore _employerRepo;
        protected readonly JobHistoryRepositore _jobHistoryRepositore;

        public ApiController(ContextDb context)
        {
            _employerRepo = new EmployeesRepositore(context);
            _jobHistoryRepositore = new JobHistoryRepositore(context);
        }
        [HttpGet]
        public string index()
        {
            return "123\n";
        }

        [HttpGet("employees")]
        public async Task<IList<EmployeesModel>> employes()
        {
            return await _employerRepo.GetEmployes();
        }

        [HttpGet("getjobs")]
        public async Task<IList<JobHistoryModel>> GetJobs()
        {
            return await _jobHistoryRepositore.GetJobs();
        }
    }
}
