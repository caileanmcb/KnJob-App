using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using my_api.Models;
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

        public async Task<ActionResult> Post(Job request)
        {
            // Add Job to Jobs table
            _dbContext.Jobs.Add(request);
            _dbContext.SaveChanges();
            return Ok(request);
        }
    }
}
