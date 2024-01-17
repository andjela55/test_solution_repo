using AutoMapper;
using Shared.Interfaces.Models;

namespace Model.UserAmountClass
{
    public class UserAmountAutoMapper : Profile
    {
        public UserAmountAutoMapper()
        {
            CreateMap<IUserAmount, UserAmount>();
        }
    }
}
