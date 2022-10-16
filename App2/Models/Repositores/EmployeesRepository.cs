using App2.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using App2.Models.Repositores.Repository;

namespace App2.Models.Repositores
{
    sealed public class EmployeesRepository : ARepository
    {
        public EmployeesRepository(ContextDb context) : base(context)
        {
        }

        public async Task<IList<EmployeesModel>> GetEmployes()
        {
            return await _context.Employees.ToListAsync();
        }
    }
}
