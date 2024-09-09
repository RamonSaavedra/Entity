using Microsoft.AspNetCore.Mvc;
using myBackend.Models;

namespace myBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EmployeesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/employees
        [HttpGet]
        public ActionResult<IEnumerable<Employee>> GetEmployees()
        {
            return Ok(_context.Employees.ToList());
        }

        [HttpPost]
        public ActionResult<Employee> CreateEmployee([FromBody] Employee employee)
{
    // Verificar que el departamento exista
    var department = _context.Departments.Find(employee.DepartmentId);
    if (department == null)
    {
        return BadRequest("Invalid DepartmentId");
    }

    _context.Employees.Add(employee);
    _context.SaveChanges();
    return CreatedAtAction(nameof(CreateEmployee), new { id = employee.Id }, employee);
}
   }
      }