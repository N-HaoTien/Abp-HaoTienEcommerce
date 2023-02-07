using System.Threading.Tasks;

namespace HaoTienEcommerce.Data;

public interface IHaoTienEcommerceDbSchemaMigrator
{
    Task MigrateAsync();
}
