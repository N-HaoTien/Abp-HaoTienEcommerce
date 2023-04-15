using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace HaoTienEcommerce.InventoryTickets
{
    public class InventoryTicketItemConfiguration : IEntityTypeConfiguration<InventoryTicketItem>
    {
        public void Configure(EntityTypeBuilder<InventoryTicketItem> builder)
        {
            builder.ToTable(HaoTienEcommerceConsts.DbTablePrefix + "InventoryTicketItems");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.SKU)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsRequired();

            builder.Property(x => x.BatchNumber)
               .HasMaxLength(50)
               .IsUnicode(false);
        }
    }
}
