using System.Threading.Tasks;
using eCommerce.Backend.Controllers;
using eCommerce.Backend.ViewModel.Products;
using eCommerce.UnitTest.BackendApiTesting.Mock.MockData;
using eCommerce.UnitTest.BackendApiTesting.Mock.MockService;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace eCommerce.UnitTest;

public class ProductsControllerTesting
{
    [Fact]
    public async Task GetProductById_ShouldReturn200Status()
    {
        //Arrange
        int productId = 1;
        ProductVM productVM = new ProductVM();
        var productStub = new MockProductService().GetProductById(ProductsMockData.GetExistProductId());

        var productController = new ProductsController(productStub.Object);
        //Art
        var productResult = (ObjectResult)await productController.GetByID(productId);
        //Assert
        productResult.StatusCode.Should().Be(200);
    }
    [Fact]
    public async Task GetProductByIdAsync_WithExistingProduct_ShouldReturn400Status()
    {
        //Arrange
        int productId = 31;
        ProductVM productVM = new ProductVM();
        var productStub = new MockProductService().GetUnExistingProductByIdAsync(ProductsMockData.GetNotExistProductId());

        var productController = new ProductsController(productStub.Object);
        //Art
        var productResult = (ObjectResult)await productController.GetByID(productId);
        //Assert
        productResult.StatusCode.Should().Be(400);
    }
    [Fact]
    public async Task GetProductsAsync_WithExistingItemsByCategoryID_ShouldReturn200Status()
    {
        //Arrange
        GetProductPagingRequest productPagingRequest = new GetProductPagingRequest()
        {
            Search = null,
            SortOrder = 0,
            SortColumn = "ID",
            PageSize = 1,
            PageIndex = 1,
            CategoryID = 4,
        };

        var productStub = new MockProductService().GetAllProductAndPaging(ProductsMockData.GetAllProductAndPaging());

        var productController = new ProductsController(productStub.Object);
        //Art
        var result = (OkObjectResult)await productController.GetAll(productPagingRequest);

        //Assert
        result.StatusCode.Should().Be(200);
    }
}