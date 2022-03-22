using Moq;
using eCommerce.Backend.Services.Products;
using eCommerce.Backend.ViewModel.Products;
using eCommerce.Shared.DTO;

namespace eCommerce.UnitTest.BackendApiTesting.Mock.MockService
{
    public class MockProductService : Mock<IProductService>
    {
        public MockProductService GetUnExistingProductByIdAsync(ProductVM result)
        {
            Setup(x => x.GetByID(It.IsAny<int>(),It.IsAny<int>())).ReturnsAsync((ProductVM)null);

            return this;
        }
        public MockProductService GetProductById(ProductVM result)
        {
            Setup(x => x.GetByID(It.IsAny<int>(),It.IsAny<int>())).ReturnsAsync(result);

            return this;
        }

        public MockProductService GetAllProductAndPaging(PagedModelDTO<ProductVM> result)
        {
            Setup(x => x.GetAllPaging(It.IsAny<GetProductPagingRequest>())).ReturnsAsync(result);

            return this;
        }
    }
}