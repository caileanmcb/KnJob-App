using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using my_api.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        public DataContext _dbContext;

        public JobController(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public async Task<ActionResult> Post(Job request)
        {
            // Add Job to Jobs table
            _dbContext.Jobs.Add(request);
            _dbContext.SaveChanges();
            return Ok(request);
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            List<Exchanges> exchanges = _dbContext.Exchanges.ToList();

            return Ok(exchanges);
        }
    }
}
 