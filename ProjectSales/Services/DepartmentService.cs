using ProjectSales.Data;
using ProjectSales.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjectSales.Services
{
    public class DepartmentService
    {
        private readonly ProjectSalesContext _context;
        
        public DepartmentService(ProjectSalesContext context)
        {
            _context = context;
        }
        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
