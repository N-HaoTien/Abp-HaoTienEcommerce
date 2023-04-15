using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace HaoTienEcommerce.Promotions
{
    public class PromotionProductConfiguration : IEntityTypeConfiguration<PromotionProduct>
    {
        public void Configure(EntityTypeBuilder<PromotionProduct> builder)
        {
            builder.ToTable(HaoTienEcommerceConsts.DbTablePrefix + "PromotionProducts");
            builder.HasKey(x => x.Id);
        }
    }
}
