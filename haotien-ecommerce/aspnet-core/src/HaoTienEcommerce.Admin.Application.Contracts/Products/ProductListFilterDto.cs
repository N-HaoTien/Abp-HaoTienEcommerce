using System;
using System.Collections.Generic;
using System.Text;

namespace HaoTienEcommerce.Admin.Products
{
    public class ProductListFilterDto : BaseListFilterDto
    {
        public Guid? CategoryId { get; set; }
    }
}
