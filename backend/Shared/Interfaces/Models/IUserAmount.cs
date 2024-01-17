namespace Shared.Interfaces.Models
{
    public interface IUserAmount
    {
        public long Id { get; }
        public long UserId { get; }
        public double Amount { get; }
    }
}
