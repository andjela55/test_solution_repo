using Model.UserClass;
using Shared.Interfaces.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.UserAmountClass
{

    [Table("UserAmount")]
    public class UserAmount : BaseEntity, IUserAmount
    {
        [Key]
        public long Id { get; set; }
        public long UserId { get; set; }
        public User User { get; set; }
        public double Amount { get; set; }
    }
}
