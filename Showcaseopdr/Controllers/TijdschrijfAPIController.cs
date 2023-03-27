using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Showcaseopdr.Data;

namespace Showcaseopdr.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TijdschrijfAPIController : ControllerBase
    {
        private readonly TaskDbContext _context;

        public TijdschrijfAPIController(TaskDbContext context)
        {
            _context = context;
        }
        
        public IActionResult Get()
        {
            var tasks = _context.Tasks.ToList();
            Console.WriteLine(tasks.Count);
            return Ok(tasks);
        }
    }
}
