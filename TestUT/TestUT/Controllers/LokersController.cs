using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestUT.Models;

namespace TestUT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LokersController : Controller
    {
        
        private MasterContext _context = new MasterContext();

        // GET: api/Lokers
        [HttpGet]
        public IEnumerable<Loker> GetLoker()
        {
            
            return _context.Loker.ToList();
        }

        // GET: api/Lokers/5
        [HttpGet("{NomerLoker}")]
        public IActionResult GetLoker( int NomerLoker)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var loker =  _context.Loker.Find(NomerLoker);

            if (loker == null)
            {
                return NotFound();
            }

            return Ok("Loker nomor "+NomerLoker+ " ada di lantai "+ loker.LantaiLoker);
        }

      
    }
}