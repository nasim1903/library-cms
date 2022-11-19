using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using library_cms.Dtos;

namespace library_cms
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Library, GetLibraryDto>();
            CreateMap<AddLibraryDto, Library>();
            CreateMap<UpdateLibraryDto, Library>();
        }
    }
}