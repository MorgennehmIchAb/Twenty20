using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Twenty20.Controllers
{
    [Route("[Controller]")]
    public class GitHookController : Controller
    {
        public async Task<IActionResult> Receive()
        {
            return Ok();
            
        }
    }
}
