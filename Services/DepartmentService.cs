using SalesWebMvc22.Models;
using SalesWebMvc22.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc22.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvc22Context _context;

        public DepartmentService(SalesWebMvc22Context context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
