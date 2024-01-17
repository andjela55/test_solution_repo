using Shared.Interfaces.Models;

namespace SharedRepository
{
    public interface IUserAmountRepository
    {
        Task<List<IUserAmount>> GetAll();
        Task<IUserAmount> GetById(long id);

        Task<double> GetAmountSumForUser(long id);
    }
}
