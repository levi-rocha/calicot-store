using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using Calicot.Store.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace Calicot.Store
{
    public interface IProductAppService : IApplicationService
    {
        Task<ListResultDto<ProductListDto>> GetAll(GetAllProductsInput input);
        Task Create(CreateProductInput input);
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
        public string ImgUrl { get; set; }
    }

    [AutoMapTo(typeof(Product))]
    public class CreateProductInput
    {
        [Required]
        [StringLength(Product.MaxTitleLength)]
        public string Title { get; set; }

        [StringLength(Product.MaxDescriptionLength)]
        public string Description { get; set; }
        public long Quantity { get; set; }
        public decimal Price { get; set; }
        public string ImgUrl { get; set; }

        public Guid? AssignedPersonId { get; set; }
    }
}
