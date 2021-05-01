using Xunit;
using Bageriet.Controllers;
using Bageriet.ViewModels;

namespace Bageriet.Test
{
    public class BagerietXunit
    {
        [Fact]
        public void ProductViewModelNotNull()
        {
            ProductListViewModel listViewModel = new ProductListViewModel();

            Assert.NotNull(listViewModel);
        }

        [Fact]
        public void HomeViewmodelNotNull()
        {
            HomeViewModel homeViewModel = new HomeViewModel();


            Assert.NotNull(homeViewModel);
        }

        [Fact]
        public void Test2()
        {
            var controller = new ContactController();
            var result = new ContactController();

            Assert.NotEqual(controller, result);
        }
    }
}