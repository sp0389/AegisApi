namespace AegisApi.API.Controllers;

public class UserController(ILogger<UserController> logger) : BaseController
{
    private readonly ILogger<UserController> _logger = logger;
}