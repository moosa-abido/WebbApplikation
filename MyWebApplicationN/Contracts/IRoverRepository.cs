using MyWebApplicationN.Models;
using System.Collections.Generic;

namespace MyWebApplicationN.Contracts
{
    public interface IRoverRepository
    {
        Task<IEnumerable<Rover>> ListAsync();
        Task<Rover> GetRoverByIdAsync(int id);
    }
}
