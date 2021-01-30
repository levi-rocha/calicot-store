using Shouldly;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Calicot.Store.Tests.Products
{
    public class ProductAppService_Tests : StoreTestBase
    {
        private readonly IProductAppService _productAppService;

        public ProductAppService_Tests()
        {
            _productAppService = Resolve<IProductAppService>();
        }

        [Fact]
        public async System.Threading.Tasks.Task Should_Get_All_Products()
        {
            //Act
            var output = await _productAppService.GetAll(new GetAllProductsInput());

            //Assert
            output.Items.Count.ShouldBe(2);
        }
    }
}
