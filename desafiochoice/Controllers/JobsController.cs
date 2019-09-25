using System.Collections.Generic;
using System.Linq;
using desafiochoice.Data;
using desafiochoice.Model;
using Microsoft.AspNetCore.Mvc;

namespace desafiochoice.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class JobsController : Controller
    {
        // GET /jobs
        [HttpGet]
        public ActionResult<IEnumerable<Job>> Get()
        {
            using (var db = new DesafioDbContext())
            {
                return db.Jobs;
            }
        }

        // GET jobs/5
        [HttpGet("{id}")]
        public ActionResult<Job> Get(int id)
        {
            using (var db = new DesafioDbContext())
            {
                return db.Jobs.First(j => j.id == id);
            }
        }
    }
}