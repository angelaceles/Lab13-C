using Lab13_C.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab13_C.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersPController : ControllerBase
    {
        private readonly InvoiceContext _context;
        public CustomersPController(InvoiceContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async List<Customer> GetCustomersP() 
        {
            if (_context.Customers == null)
            {
                return NotFound();
            }
            return await _context.Customers.ToListAsync();
        }
    }
}
