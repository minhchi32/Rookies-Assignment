namespace eCommerce.Backend.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductColorsController : Controller
{
    readonly IProductColorService productColorService;

    public ProductColorsController(IProductColorService productColorService)
    {
        this.productColorService = productColorService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var products = await productColorService.GetAll();
        return Ok(products);
    }

    [HttpPost("{id}")]
    public async Task<IActionResult> GetByID(int id)
    {
        var product = await productColorService.GetByID(id);
        if (product == null) return BadRequest(MessageConstants.ProductNotExist);
        return Ok(product);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromForm] ProductColorCreateRequest request)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);
        var productColorID = await productColorService.Create(request);
        if (productColorID == 0) return BadRequest();
        var product = await productColorService.GetByID(productColorID);
        return CreatedAtAction(nameof(GetByID), new { id = productColorID }, product);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromForm] ProductColorUpdateRequest request)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);
        var result = await productColorService.Update(request);
        if (result == 0) return BadRequest();
        return Ok();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await productColorService.Delete(id);
        if (result == 0) return BadRequest();
        return Ok();
    }
}
