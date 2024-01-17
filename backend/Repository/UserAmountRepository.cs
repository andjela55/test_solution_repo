using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Model.ContextFolder;
using Model.UserAmountClass;
using Shared.Interfaces.Models;
using SharedRepository;

namespace Repository
{
    public class UserAmountRepository : BaseRepository<UserAmount, IUserAmount>, IUserAmountRepository
    {
        private Context _context;
        public UserAmountRepository(Context context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
        }
        public async Task<List<IUserAmount>> GetAll()
        {
            var users = await GetAll();
            return users;
        }

        public async Task<IUserAmount> GetById(long id)
        {
            var user = await GetById(id);
            return user;
        }
        public async Task<double> GetAmountSumForUser(long id)
        {
            var userAmountsSum = await _context.UserAmounts.Where(x => x.UserId == id).Select(x => x.Amount).SumAsync();
            return userAmountsSum;
        }
    }
}
