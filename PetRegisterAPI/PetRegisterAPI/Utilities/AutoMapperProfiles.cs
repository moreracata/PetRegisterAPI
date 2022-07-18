using AutoMapper;
using PetRegisterAPI.Models;
using PetRegisterAPI.ModelsDTO;

namespace PetRegisterAPI.Utilities
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Pet, PetDTO>().ReverseMap();
            CreateMap<Owner, OwnerDTO>().ReverseMap();
            CreateMap<Category, CategoryDTO>().ReverseMap();
        }
     }
}
