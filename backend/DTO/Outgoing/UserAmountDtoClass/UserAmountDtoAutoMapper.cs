using AutoMapper;
using Shared.Interfaces.Models;

namespace DTO.Outgoing.UserAmountDtoClass
{
    public class UserAmountDtoAutoMapper : Profile
    {
        public UserAmountDtoAutoMapper()
        {
            CreateMap<IUserAmount, UserAmountDto>();
        }
    }
}
