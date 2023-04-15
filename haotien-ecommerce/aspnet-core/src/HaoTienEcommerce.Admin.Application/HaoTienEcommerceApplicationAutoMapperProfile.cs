using AutoMapper;
using HaoTienEcommerce.Admin.Manufacturers;
using HaoTienEcommerce.Admin.ProductCategories;
using HaoTienEcommerce.Admin.Products;
using HaoTienEcommerce.Manufacturers;
using HaoTienEcommerce.ProductCategories;
using HaoTienEcommerce.Products;

namespace HaoTienEcommerce.Admin;

public class HaoTienEcommerceApplicationAutoMapperProfile : Profile
{
    // Hello12312
    public HaoTienEcommerceApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        //Product Category
        CreateMap<ProductCategory, ProductCategoryDto>();
        CreateMap<ProductCategory, ProductCategoryInListDto>();
        CreateMap<CreateUpdateProductCategoryDto, ProductCategory>();

        //Product
        CreateMap<Product, ProductDto>();
        CreateMap<Product, ProductInListDto>();
        CreateMap<CreateUpdateProductDto, Product>();

        //Manufacturer
        CreateMap<Manufacturer, ManufacturerDto>();
        CreateMap<Manufacturer, ManufacturerInListDto>();
        CreateMap<CreateUpdateManufacturerDto, Manufacturer>();
    }
}
