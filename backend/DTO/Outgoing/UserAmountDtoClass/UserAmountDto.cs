using Shared.Interfaces.Models;

namespace DTO.Outgoing.UserAmountDtoClass
{
    public class UserAmountDto : IUserAmount
    {
        public long Id { get; set; }

        public long UserId { get; set; }

        public double Amount { get; set; }

        public UserDto User { get; set; }

    }
}
