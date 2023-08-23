using AutoMapper;
using Commander.Dtos;
using Commander.Models;

namespace Commander.Profiles{
    public class CommandsProfile : Profile{ //Inherit from a base class
        public CommandsProfile()
        {
            //Source -> Target
            CreateMap<Command, CommandReadDto>(); //Mapping from source object to a destination object, from and to
            CreateMap<CommandCreateDto, Command>();
            CreateMap<CommandUpdateDto, Command>();
            CreateMap<Command, CommandUpdateDto>();
        }
    }
}