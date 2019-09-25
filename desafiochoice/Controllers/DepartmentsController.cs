using System.Collections.Generic;
using System.Linq;
using desafiochoice.Data;
using desafiochoice.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace desafiochoice.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        // GET /departments
        [HttpGet]
        public ActionResult<IEnumerable<Department>> Get()
        {
            using (var db = new DesafioDbContext())
            {
                return db.Departments;
            }
        }

        // GET departments/5
        [HttpGet("{id}")]
        public ActionResult<Department> Get(int id)
        {
            using (var db = new DesafioDbContext())
            {
                return db.Departments.First(d => d.id == id);
            }
        }
    }
}