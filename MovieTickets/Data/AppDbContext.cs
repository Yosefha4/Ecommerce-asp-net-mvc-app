using Microsoft.EntityFrameworkCore;

namespace MovieTickets.Data
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }
    }
}
