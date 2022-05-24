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
        private DataContext _dbContext;

        public JobController(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ActionResult> Post(Job request)
        {
            _dbContext.

            return Ok(request);
        }
    }
}
