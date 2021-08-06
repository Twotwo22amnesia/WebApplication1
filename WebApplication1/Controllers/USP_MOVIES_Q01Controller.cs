using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Context;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    public class USP_MOVIES_Q01Controller : Controller
    {
        private readonly ApplicationDbContext _context;
        public USP_MOVIES_Q01Controller(ApplicationDbContext context)
        {
            _context = context; ;
        }
        // GET: api/<controller>
        [HttpGet]
        public ActionResult Get(string filt)
        {
            try
            {
                var list = _context.USP_MOVIES_Q01.FromSql("USP_MOVIES_Q01 @p0", filt).ToList();
                return Ok(list);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
