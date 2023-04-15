using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace HaoTienEcommerce.Products
{
    public class ProductLinkConfiguration : IEntityTypeConfiguration<ProductLink>
    {
        public void Configure(EntityTypeBuilder<ProductLink> builder)
        {
            builder.ToTable(HaoTienEcommerceConsts.DbTablePrefix + "ProductLinks");
            builder.HasKey(x => new { x.ProductId, x.LinkedProductId });
        }
    }
}
