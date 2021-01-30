using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calicot.Store.Web.ViewModels
{
    public class IndexViewModel
    {
        public IReadOnlyList<ProductListDto> Products { get; }

        public IndexViewModel(IReadOnlyList<ProductListDto> products)
        {
            Products = products;
        }

        public string GetProductLabel(ProductListDto products)
        {
            switch (products.Quantity)
            {
                case 0:
                    return "label-default";
                default:
                    return "label-success";
            }
        }
    }
}
