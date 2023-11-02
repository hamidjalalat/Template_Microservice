using AutoMapper;
using HJMST.Application.Googoolis.Commands;
using HJMST.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HJMST.Application.Googoolis
{
    public class MappingProfile : Profile
    {
        public MappingProfile() : base()
        {
            CreateMap<CreateGoogooliCommand, Googooli>();
            CreateMap<Googooli, CreateGoogooliCommand>();
        }
    }
}
