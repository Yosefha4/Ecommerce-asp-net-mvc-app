using MovieTickets.Models;
using System.Collections;

namespace MovieTickets.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAll();

        Task<Actor> GetByIdAsync(int id);

        Task Add(Actor actor);

        Task<Actor> Update(int id, Actor newActor);

        Task DeleteAsync(int id);
    }
}
