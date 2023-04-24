using cityscapehub.Data.DatabaseContext;
using cityscapehub.Model.DbModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cityscapehub_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public readonly CityscapehubDataContext _dbContext;
        public ProductController(CityscapehubDataContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Test([FromBody] Category param)
        {
            try
            {
                _dbContext.Category.Add(param);
                _dbContext.SaveChanges();
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }
            

    }
}
