namespace eCommerce.Backend.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RatesController : Controller
{
    readonly IRateService rateService;

    public RatesController(IRateService rateService)
    {
        this.rateService = rateService;
    }

    [HttpGet("paging")]
    public async Task<IActionResult> GetAllPaging([FromQuery] GetRatePagingRequest request)
    {
        var rates = await rateService.GetAllPaging(request);
        return Ok(rates);
    }

    [HttpGet("{rateID}")]
    public async Task<IActionResult> GetByID(int rateID)
    {
        var rate = await rateService.GetByID(rateID);
        if (rate == null) return BadRequest(MessageConstants.RateNotExistID);
        return Ok(rate);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromForm] RateCreateRequest request)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);
        var rateID = await rateService.Create(request);
        if (rateID == 0) return BadRequest();
        var rate = await rateService.GetByID(rateID);
        return CreatedAtAction(nameof(GetByID), new { id = rateID }, rate);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromForm] RateUpdateRequest request)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);
        var result = await rateService.Update(request);
        if (result == 0) return BadRequest();
        return Ok();
    }

    [HttpPut("{rateID}")]
    public async Task<IActionResult> Delete(int rateID)
    {
        var result = await rateService.Delete(rateID);
        if (result == 0) return BadRequest();
        return Ok();
    }

    [HttpGet("rating/{productID}")]
    public async Task<IActionResult> GetAll(int productID)
    {
        var rates = await rateService.GetAllRate(productID);
        return Ok(rates);
    }
}
