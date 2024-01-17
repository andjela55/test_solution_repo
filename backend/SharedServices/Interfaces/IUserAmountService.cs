namespace SharedServices.Interfaces
{
    public interface IUserAmountService
    {
        Task<double> GetAmountForUser(long id);
    }
}
