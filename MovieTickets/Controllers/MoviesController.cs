using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieTickets.Data;

namespace MovieTickets.Controllers
{
    public class MoviesController : Controller
    {


        private readonly AppDbContext _context;

        public MoviesController(AppDbContext context)
        {
            _context = context;   
        }
        public async Task<IActionResult> Index()
        {

            var allMovies = await _context.Movies.ToListAsync();
            return View();
        }
    }
}
