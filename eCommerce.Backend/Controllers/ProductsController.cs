namespace eCommerce.Backend.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : Controller
{
    readonly IProductService productService;

    public ProductsController(IProductService productService)
    {
        this.productService = productService;
    }

    [HttpGet("all")]
    public async Task<IActionResult> GetAll()
    {
        var products = await productService.GetAll();
        return Ok(products);
    }

    [HttpGet("get4product")]
    public async Task<IActionResult> Get4Product()
    {
        var products = await productService.Get4Product();
        return Ok(products);
    }

    // [HttpGet("paging")]
    // public async Task<IActionResult> GetAllPaging([FromQuery] GetProductPagingRequest request)
    // {
    //     var products = await productService.GetAllByCategoryID(request);
    //     return Ok(products);
    // }

    

    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] GetProductPagingRequest request)
    {
        try
        {
            return Ok(await productService.GetAllByCategoryID(request));
        }
        catch (Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                "Error retrieving data from the database");
        }
    }

    [HttpGet("{productID}/{colorID}")]
    public async Task<IActionResult> GetByID(int productID, int colorID = 0)
    {
        var product = await productService.GetByID(productID, colorID);
        if (product == null) return BadRequest(MessageConstants.ProductNotExist);
        return Ok(product);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromForm] ProductCreateRequest request)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);
        var result = await productService.Create(request);
        return Ok(result);
    }

    [HttpPut("{productID}")]
    public async Task<IActionResult> Update(int id, [FromForm] ProductUpdateRequest request)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);
        var result = await productService.Update(id, request);
        if (result == 0) return BadRequest();
        return Ok();
    }

    [HttpDelete("{productID}")]
    public async Task<IActionResult> Delete(int productID)
    {
        var result = await productService.Delete(productID);
        if (result == 0) return BadRequest();
        return Ok();
    }

    [HttpPatch("addQuantitySale/{productID}")]
    public async Task<IActionResult> UpdateQuantitySale(int productID)
    {
        var isSuccessful = await productService.AddQuantitySale(productID);
        return isSuccessful ? Ok() : BadRequest();
    }

    [HttpPatch("addPointRate/{productID}/{pointRate}")]
    public async Task<IActionResult> UpdatePointRate(int productID, int pointRate)
    {
        var isSuccessful = await productService.AddPointRate(productID, pointRate);
        return isSuccessful ? Ok() : BadRequest();
    }
}
