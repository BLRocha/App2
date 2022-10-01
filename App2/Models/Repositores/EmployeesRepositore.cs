using App2.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace App2.Models.Repositores
{
    public class EmployeesRepositore
    {

        protected readonly ContextDb _context;

        public EmployeesRepositore(ContextDb context)
        {
            _context = context;
        }

        public async Task<IList<EmployeesModel>> GetEmployes()
        {
            return await _context.Employees.ToListAsync();
        }
    }
}
