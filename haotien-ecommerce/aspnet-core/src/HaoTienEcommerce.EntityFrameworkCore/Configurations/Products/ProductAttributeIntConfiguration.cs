using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace HaoTienEcommerce.Products
{
    public class ProductAttributeIntConfiguration : IEntityTypeConfiguration<ProductAttributeInt>
    {
        public void Configure(EntityTypeBuilder<ProductAttributeInt> builder)
        {
            builder.ToTable(HaoTienEcommerceConsts.DbTablePrefix + "ProductAttributeInts");
            builder.HasKey(x => x.Id);
        }
    }
}
