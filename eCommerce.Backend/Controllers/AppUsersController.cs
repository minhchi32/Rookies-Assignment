namespace eCommerce.Backend.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AppUsersController : Controller
{
    readonly IAppUserService appUserService;

    public AppUsersController(IAppUserService appUserService)
    {
        this.appUserService = appUserService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] PagedResultBase request)
    {
        try
        {
            return Ok(await appUserService.GetAllWithPaging(request));
        }
        catch (Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                "Error retrieving data from the database");
        }
    }

    [HttpGet("{appUserID}")]
    public async Task<IActionResult> GetByID(int appUserID)
    {
        var user = await appUserService.GetByID(appUserID);
        if (user == null) return BadRequest(MessageConstants.AppUserNotExistID);
        return Ok(user);
    }
}
