using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyWebApplicationN.Contracts;
using MyWebApplicationN.Data.Rover;
using MyWebApplicationN.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyWebApplicationN.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoversController : ControllerBase
    {
        private readonly IRoverRepository _roversRepository;
        private readonly IMapper _mapper;

        public RoversController(IRoverRepository roversRepository, IMapper mapper)
        {
            _roversRepository = roversRepository;
            _mapper = mapper;
        }




        // GET: api/RoversController
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RoverDto>>> GetRovers()
        {
            var rovers = await _roversRepository.ListAsync();

            var record = _mapper.Map<IEnumerable<Rover>, IEnumerable<RoverDto>>(rovers);
            //var record = _mapper.Map<IList<Rover>, IList<RoverDto>>((IList<Rover>)rovers);

            return Ok(record);
        }

        // GET api/<RoversController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<RoverDto>>> GetRoversById(int id)
        {

            var rover = await _roversRepository.GetRoverByIdAsync(id);

            if (rover == null)
            {
                return NotFound();
            }
            var record = _mapper.Map<Rover, RoverDto>(rover);

            return Ok(record);
        }

    }
}
