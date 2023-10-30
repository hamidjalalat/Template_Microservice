using AutoMapper;
using HJMST.Application.Users.Commands;
using HJMST.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HJMST.Application.Users
{
    public class MappingProfile : Profile
    {
        public MappingProfile() : base()
        {
            CreateMap<CreateUserCommand, User>();
            CreateMap<User, CreateUserCommand>();
        }
    }
}
