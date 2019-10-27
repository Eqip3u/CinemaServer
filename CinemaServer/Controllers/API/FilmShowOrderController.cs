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
    public class FilmShowOrderController : ControllerBase
    {
        private readonly CinemaContext _context;

        public FilmShowOrderController(CinemaContext context)
        {
            _context = context;
        }

        // POST: api/filmshoworder
        [HttpPost]
        public async Task<ActionResult<FilmOrder>> PostFilmOrder(FilmOrder filmOrder)
        {
            _context.FilmOrders.Add(filmOrder);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFilmOrder", new { id = filmOrder.Id }, filmOrder);
        }
    }
}
