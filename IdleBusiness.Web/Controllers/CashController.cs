namespace IdleBusiness.Web.Controllers;

public class CashController : BaseController
{
    private readonly ICashService _cashService;

    public CashController(ICashService cashService)
    {
        _cashService = cashService;
    }

    public IActionResult Index(int pId)
    {


    }
}