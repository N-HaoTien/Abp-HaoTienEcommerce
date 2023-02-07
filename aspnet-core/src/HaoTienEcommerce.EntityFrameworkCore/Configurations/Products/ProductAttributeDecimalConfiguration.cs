

using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace HaoTienEcommerce.Products
{
    public class ProductAttributeDecimalConfiguration : IEntityTypeConfiguration<ProductAttributeDecimal>
    {
        public void Configure(EntityTypeBuilder<ProductAttributeDecimal> builder)
        {
            builder.ToTable(HaoTienEcommerceConsts.DbTablePrefix + "ProductAttributeDecimals");
            builder.HasKey(x => x.Id);
        }
    }
}
