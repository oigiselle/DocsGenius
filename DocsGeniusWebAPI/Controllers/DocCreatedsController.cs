using Microsoft.AspNetCore.Mvc;
using DocsGenius.Models;
using System.Collections.Generic;
using DocsGeniusWebAPI.Data;

namespace DocsGenius.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocCreatedsController : ControllerBase
    {
        private ApiDbContext _dbContext;
        public DocCreatedsController(ApiDbContext dbContext)
        {
            _dbContext = dbContext;
        }

    }
}
