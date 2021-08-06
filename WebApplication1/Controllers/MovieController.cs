using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Context;
using WebApplication1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    public class MovieController : Controller
    {
        private readonly ApplicationDbContext _context;
        public MovieController(ApplicationDbContext context )
        {
            _context = context; ;
        }
        // GET: api/<controller>
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(_context.MOVIES.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
       
        // GET api/<controller>/5
        [HttpGet("{id}", Name = "GetMovie")]
        public ActionResult Get(int id)
        {
            try
            {
                var Movie = _context.MOVIES.Find(id);
                return Ok(Movie);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<controller>
        [HttpPost]
        public ActionResult Post([FromBody]MOVIES mOVIE)
        {
            try
            {
                mOVIE.INT_IDD_MOVIE = 0;
            _context.MOVIES.Add(mOVIE);
            _context.SaveChanges();
            return CreatedAtRoute("GetMovie", new {id = mOVIE.INT_IDD_MOVIE }, mOVIE);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message); 
            }
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody]MOVIES mOVIE)
        {
            try
            {
                if(mOVIE.INT_IDD_MOVIE == id)
                {
                    _context.Entry(mOVIE).State = EntityState.Modified;
                    _context.SaveChanges();
                    return CreatedAtRoute("GetMovie", new { id = mOVIE.INT_IDD_MOVIE }, mOVIE);
                }else
                {
                    return BadRequest(); 
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var mOVIE = _context.MOVIES.Find(id);
                if(mOVIE != null)
                {
                    _context.MOVIES.Remove(mOVIE);
                    _context.SaveChanges();
                    return Ok(id);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message); 
            }
        }
    }
}
