using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Calicot.Store;
using Calicot.Store.Products;
using Microsoft.EntityFrameworkCore;

namespace Acme.SimpleTaskApp.Tasks
{
    public class ProductAppService : StoreAppServiceBase, IProductAppService
    {
        private readonly IRepository<Product> _productRepository;

        public ProductAppService(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<ListResultDto<ProductListDto>> GetAll(GetAllProductsInput input)
        {
            var products = await _productRepository
                .GetAll()
                .OrderByDescending(t => t.CreationTime)
                .ToListAsync();

            return new ListResultDto<ProductListDto>(
                ObjectMapper.Map<List<ProductListDto>>(products)
            );
        }
    }
}