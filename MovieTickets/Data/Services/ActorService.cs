using Microsoft.EntityFrameworkCore;
using MovieTickets.Models;

namespace MovieTickets.Data.Services
{
    public class ActorService : IActorsService
    {
        private readonly AppDbContext _context;

        public ActorService(AppDbContext context)
        {
            _context = context;
        }

        public async Task Add(Actor actor)
        {
            await _context.Actors.AddAsync(actor);
            await _context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetAll()
        {
            var result = await _context.Actors.ToListAsync();
            return result;
        }

        public async Task<Actor> GetByIdAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }

        public Actor Update(int id, Actor newActor)
        {
            throw new NotImplementedException();
        }
    }
}
