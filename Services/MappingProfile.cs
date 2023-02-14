﻿using AutoMapper;
using Common.DTOs;
using repositories.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User,UserDTO>().ReverseMap();

            CreateMap<Child,ChildDTO>().ReverseMap();
        }
    }
}
