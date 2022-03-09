namespace eCommerce.Backend.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : Controller
{
    private readonly IPublicProductService publicProductService;
    readonly IManageProductService manageProductService;

    public ProductsController(IPublicProductService publicProductService, IManageProductService manageProductService)
    {
        this.publicProductService = publicProductService;
        this.manageProductService = manageProductService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var products = await publicProductService.GetAll();
        return Ok(products);
    }

    [HttpGet("paging")]
    public async Task<IActionResult> GetAllPaging([FromQuery] GetProductPagingRequest request)
    {
        var products = await publicProductService.GetAllByCategoryID(request);
        return Ok(products);
    }

    [HttpPost("{productID}/{colorID}")]
    public async Task<IActionResult> GetByID(int productID, int colorID)
    {
        var product = await manageProductService.GetByID(productID, colorID);
        if (product == null) return BadRequest(MessageConstants.ProductNotExist);
        return Ok(product);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromForm] ProductCreateRequest request)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);
        var productID = await manageProductService.Create(request);
        if (productID == 0) return BadRequest();
        var product = await manageProductService.GetByID(productID);
        return CreatedAtAction(nameof(GetByID), new { id = productID }, product);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromForm] ProductUpdateRequest request)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);
        var result = await manageProductService.Update(request);
        if (result == 0) return BadRequest();
        return Ok();
    }

    [HttpPut("{productID}")]
    public async Task<IActionResult> Delete(int productID)
    {
        var result = await manageProductService.Delete(productID);
        if (result == 0) return BadRequest();
        return Ok();
    }

    [HttpPatch("addQuantitySale/{productID}")]
    public async Task<IActionResult> UpdateQuantitySale(int productID)
    {
        var isSuccessful = await manageProductService.AddQuantitySale(productID);
        return isSuccessful ? Ok() : BadRequest();
    }

    [HttpPatch("addPointRate/{productID}/{pointRate}")]
    public async Task<IActionResult> UpdatePointRate(int productID, int pointRate)
    {
        var isSuccessful = await manageProductService.AddPointRate(productID, pointRate);
        return isSuccessful ? Ok() : BadRequest();
    }
}
