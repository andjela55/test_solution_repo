using SharedRepository;
using SharedServices.Interfaces;

namespace Services
{
    public class UserAmountService : IUserAmountService
    {
        private IUserAmountRepository _userAmountRepository;
        public UserAmountService(IUserAmountRepository userAmountRepository)
        {
            _userAmountRepository = userAmountRepository;
        }
        public async Task<double> GetAmountForUser(long id)
        {
            var amountsSum = await _userAmountRepository.GetAmountSumForUser(id);
            return amountsSum;
        }
    }
}
