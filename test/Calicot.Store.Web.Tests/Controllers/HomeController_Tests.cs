using System.Threading.Tasks;
using Calicot.Store.Web.Controllers;
using Shouldly;
using Xunit;

namespace Calicot.Store.Web.Tests.Controllers
{
    public class HomeController_Tests: StoreWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
