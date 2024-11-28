using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAPI_oppgave.Data;

namespace RestAPI_oppgave.Controllers

{

    [Route("api/movies")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        
        private readonly ApplicationDbContext _context;

        public MoviesController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll() 
        {
            var movies = await _context.Movies.ToListAsync();
            return Ok(movies);
        }
        
    }
}