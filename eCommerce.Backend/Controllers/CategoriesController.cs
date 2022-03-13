namespace eCommerce.Backend.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoriesController : Controller
{
    readonly ICategoryService categoryService;

    public CategoriesController(ICategoryService categoryService)
    {
        this.categoryService = categoryService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var categories = await categoryService.GetAll();
        return Ok(categories);
    }

    [HttpPost("{categoryID}")]
    public async Task<IActionResult> GetByID(int categoryID)
    {
        var product = await categoryService.GetByID(categoryID);
        if (product == null) return BadRequest(MessageConstants.CategoryNotExistID);
        return Ok(product);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromForm] CategoryCreateRequest request)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);
        var categoryID = await categoryService.Create(request);
        if (categoryID == 0) return BadRequest();
        var category = await categoryService.GetByID(categoryID);
        return CreatedAtAction(nameof(GetByID), new { id = categoryID }, category);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromForm] CategoryUpdateRequest request)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);
        var result = await categoryService.Update(request);
        if (result == 0) return BadRequest();
        return Ok();
    }

    [HttpPut("{categoryID}")]
    public async Task<IActionResult> Delete(int categoryID)
    {
        var result = await categoryService.Delete(categoryID);
        if (result == 0) return BadRequest();
        return Ok();
    }

    [HttpGet("paging")]
    public async Task<IActionResult> GetAllPaging([FromQuery] GetProductPagingRequest request)
    {
        var products = await categoryService.GetListProductCategoryID(request);
        return Ok(products);
    }
}
