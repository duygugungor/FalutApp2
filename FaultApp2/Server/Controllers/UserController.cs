using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FaultApp2.Shared.Models;
using FaultApp2.Server.Data;
using Microsoft.EntityFrameworkCore;

namespace FaultApp2.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public UserController(ApplicationDBContext context )
        {
       
            _context = context;
        }
        [HttpGet("{UserName}")]
        public async Task<IActionResult> GetOperator(String UserName)
        {
            var opt = await GetOperators().FirstOrDefaultAsync(p=> p.NameSurname ==UserName);
            return Ok(opt);
        }

        private DbSet<Operator> GetOperators()
        {
            return _context.Operators;
        }

    }
}
