using cityscapehub.Data.DatabaseContext;
using cityscapehub.Model.DbModels;
using Microsoft.AspNetCore.Http;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public async Task<object> Test([FromBody] Category param)
        {
            try
            {
                _dbContext.Categories.Add(param);
                await _dbContext.SaveChangesAsync();
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }
            

    }
}
