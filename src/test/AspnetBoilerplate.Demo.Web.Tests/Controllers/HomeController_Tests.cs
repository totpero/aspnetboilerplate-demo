using System.Threading.Tasks;
using AspnetBoilerplate.Demo.Models.TokenAuth;
using AspnetBoilerplate.Demo.Web.Controllers;
using Shouldly;
using Xunit;

namespace AspnetBoilerplate.Demo.Web.Tests.Controllers
{
    public class HomeController_Tests: DemoWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}