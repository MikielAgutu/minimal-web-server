using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace WebServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> GetAll()
        {
            return new[]
            {
                "SQL Source Control"
            };
        }
    }
}
