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
    public async Task<IActionResult> Get()
    {
        var products = await publicProductService.GetAll();
        return Ok(products);
    }

    [HttpGet("paging")]
    public async Task<IActionResult> Get([FromQuery] GetProductPagingRequest request)
    {
        var products = await publicProductService.GetAllByCategoryID(request);
        return Ok(products);
    }

    [HttpPost("{id}/{colorID}")]
    public async Task<IActionResult> GetByID(int id, int colorID)
    {
        var product = await manageProductService.GetByID(id, colorID);
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

    [HttpPut("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await manageProductService.Delete(id);
        if (result == 0) return BadRequest();
        return Ok();
    }

    [HttpPatch("addQuantitySale/{id}")]
    public async Task<IActionResult> UpdateQuantitySale(int id)
    {
        var isSuccessful = await manageProductService.AddQuantitySale(id);
        return isSuccessful ? Ok() : BadRequest();
    }

    [HttpPatch("addPointRate/{id}/{pointRate}")]
    public async Task<IActionResult> UpdatePointRate(int id, int pointRate)
    {
        var isSuccessful = await manageProductService.AddPointRate(id, pointRate);
        return isSuccessful ? Ok() : BadRequest();
    }
}
