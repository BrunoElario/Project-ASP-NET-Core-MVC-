using ProjectSales.Data;
using ProjectSales.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjectSales.Services
{
    public class SellerService
    {
        private readonly ProjectSalesContext _context;

        public SellerService(ProjectSalesContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

    }
}
