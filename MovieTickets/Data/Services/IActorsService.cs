using MovieTickets.Models;
using System.Collections;

namespace MovieTickets.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAll();

        Task<Actor> GetByIdAsync(int id);

        Task Add(Actor actor);

        Actor Update(int id, Actor newActor);

        void Delete(int id);
    }
}
