using AutoMapper;
using Database.EFCore.Entities;
using Microsoft.AspNetCore.Routing.Constraints;

namespace WebApplication.EFCore
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            this.CreateMap<NoteEntity, Notes>()
                .ForMember(dst => dst.id, opt => opt.MapFrom(src => src.id))
                .ForMember(dst => dst.dateTime, opt => opt.MapFrom(src => src.dateTime))
                .ForMember(dst => dst.text, opt => opt.MapFrom(src => src.text))
                .ForMember(dst => dst.user, opt => opt.MapFrom(src => src.user));
        }
    }
}