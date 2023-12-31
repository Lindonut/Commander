using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Commander.Dtos;
using Commander.Models;

namespace Commander.Profiles
{
    public class CommandProfile:Profile
    {
        public CommandProfile()
        {
            CreateMap<Command, CommandReadDto>();
            CreateMap< CommandCreateDto, Command>();
            CreateMap< CommandUpdateDto, Command>();
            CreateMap< Command, CommandUpdateDto>(); 
        }
    }
}