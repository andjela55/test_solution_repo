using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Model.UserAmountClass
{
    public class UserAmountConfiguration : IEntityTypeConfiguration<UserAmount>
    {
        public void Configure(EntityTypeBuilder<UserAmount> builder)
        {
            builder.HasOne(x => x.User)
                   .WithMany(x => x.UserAmounts)
                   .HasForeignKey(x => x.UserId);
        }
    }
}
