namespace AegisApi.API.Controllers;

public class VaultItemController(ILogger<VaultItemController> logger) : BaseController
{
    private readonly ILogger<VaultItemController> _logger = logger;
}