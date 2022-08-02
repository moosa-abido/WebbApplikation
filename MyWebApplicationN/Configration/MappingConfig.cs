using AutoMapper;
using MyWebApplicationN.Data.Rover;
using MyWebApplicationN.Models;

namespace MyWebApplicationN.Configration
{
    public class MappingConfig:Profile
    {

        public MappingConfig()
        {

            CreateMap<Rover, RoverDto>().ReverseMap();
            

        }

    }
}
