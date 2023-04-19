using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_BackendAPI
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
        }
    }
}
