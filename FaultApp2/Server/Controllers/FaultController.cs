using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FaultApp2.Shared.Models;
using FaultApp2.Server.Data;

namespace FaultApp2.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FaultController : ControllerBase
    {

        private readonly ApplicationDBContext _context;

        public FaultController(ApplicationDBContext context) => _context = context;
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var faults = await _context.Faults.ToListAsync();
            return Ok(faults);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var fault = await GetFaults().FirstOrDefaultAsync(a => a.Id == id);
            return Ok(fault);
        }

        [HttpGet]
        [Route("query")] // <- no route parameters specified
        public IActionResult filterByParameters([FromQuery] long afterTimestamp,
                                              [FromQuery] long beforeTimestamp/*,*/
                                              /*[FromQuery] string status*/)
        {

            DateTime after = DateTimeOffset.FromUnixTimeMilliseconds(afterTimestamp).DateTime/*.SpecifyKind(dtDateTime, DateTimeKind.Local); */;
            DateTime before = DateTimeOffset.FromUnixTimeMilliseconds(beforeTimestamp).DateTime/*.UtcNow.ToLocalTime()*/;

            var _faults = new List<Fault>();
            ;
            _faults = _context.Faults.Where(p => DateTime.Compare(p.CreatedTime, after) > 0 && DateTime.Compare(p.CreatedTime, before) < 0).ToList();

           
            return Ok(_faults);
        }

        private DbSet<Fault> GetFaults()
        {
            return _context.Faults;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Fault fault)
        {
            _context.Add(fault);
            await _context.SaveChangesAsync();
            return Ok(fault.Id);
        }

        [HttpPut]
        public async Task<IActionResult> Put(Fault fault)
        {
            _context.Entry(fault).State = EntityState.Modified;

            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> EditFault(int id, Fault fault)
        {
            if (id != fault.Id)
            {
                return BadRequest();
            }
            _context.Entry(fault).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var fault = new Fault { Id = id };
            _context.Remove(fault);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        protected DateTime UnixTimeStampToDateTime(long unixTimeStamp)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp);
            return dtDateTime;


        }

    }
}
