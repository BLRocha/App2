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
        protected readonly EmployeesRepository _employerRepository;
        protected readonly JobHistoryRepository _jobHistoryRepository;

        public ApiController(ContextDb context)
        {
            _employerRepository = new EmployeesRepository(context);
            _jobHistoryRepository = new JobHistoryRepository(context);
        }
        [HttpGet]
        public string index()
        {
            return "123\n";
        }

        [HttpGet("employees")]
        public async Task<IList<EmployeesModel>> employes()
        {
            return await _employerRepository.GetEmployes();
        }

        [HttpGet("getjobs")]
        public async Task<IList<JobHistoryModel>> GetJobs()
        {
            return await _jobHistoryRepository.GetJobs();
        }
    }
}
