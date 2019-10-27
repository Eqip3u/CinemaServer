using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CinemaServer.Data;
using CinemaServer.Models;

namespace CinemaServer.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmShowsController : ControllerBase
    {
        private readonly CinemaContext _context;

        public FilmShowsController(CinemaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FilmShow>>> GetFilmShows()
        {
            return await _context.FilmShows.ToListAsync();
        }
    }
}
