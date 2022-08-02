using Microsoft.EntityFrameworkCore;
using MyWebApplicationN.Context;
using MyWebApplicationN.Contracts;

namespace MyWebApplicationN.Models.Repositories
{
    public class RoversRepository : BaseRepository, IRoverRepository

    {



        public RoversRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<Rover> GetRoverByIdAsync(int id)
        {
            return await _context.rovers.FirstOrDefaultAsync(h => h.Id == id);
        }

        public async Task<IEnumerable<Rover>> ListAsync()
        {
            return await _context.rovers.ToListAsync();

        }
    }
}
