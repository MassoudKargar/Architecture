namespace Solution.Web.Controllers;

public class Users : Controller
{
    private IMediator Mediator { get; }

    public Users(IMediator mediator)
    {
        Mediator = mediator;
    }

    public IActionResult Index()
    {
        return View();
    }
}
