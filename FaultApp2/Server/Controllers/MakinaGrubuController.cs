using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FaultApp2.Server.Data;
using FaultApp2.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FaultApp2.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MakinaGrubuController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public MakinaGrubuController(ApplicationDBContext context)
        {

            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var faults = await _context.MakinaGrubus.ToListAsync();
            return Ok(faults);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOperator(int id)
        {
            var opt = await GetMakinaGrubus().FirstOrDefaultAsync(p => p.Id == id);
            return Ok(opt);
        }

        private DbSet<MakinaGrubu> GetMakinaGrubus()
        {
            return _context.MakinaGrubus;
        }

    }
}
