using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using Calicot.Store.Products;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Calicot.Store
{
    public interface IProductAppService : IApplicationService
    {
        Task<ListResultDto<ProductListDto>> GetAll(GetAllProductsInput input);
    }

    public class GetAllProductsInput
    {
    }

    [AutoMapFrom(typeof(Product))]
    public class ProductListDto : EntityDto, IHasCreationTime
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime CreationTime { get; set; }

        public long Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
