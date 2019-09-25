using System.Collections.Generic;
using System.Linq;
using desafiochoice.Data;
using desafiochoice.Model;
using Microsoft.AspNetCore.Mvc;

namespace desafiochoice.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeesController : Controller
    {
        // GET /employees
        [HttpGet]
        public ActionResult<IEnumerable<Employee>> Get()
        {
            using (var db = new DesafioDbContext())
            {
                return db.Employees;
            }
        }

        // GET employees/5
        [HttpGet("{id}")]
        public ActionResult<Employee> Get(int id)
        {
            using (var db = new DesafioDbContext())
            {
                return db.Employees.First(e => e.id == id);
            }
        }
        
        
        // POST 
        [HttpPost]
        public void Post([FromBody] Employee e)
        {
            using (var db = new DesafioDbContext())
            {
                db.Employees.Add(e);
            }
        }
    }
}