namespace Solution.Web.Controllers;

public class Home : Controller
{
    private readonly ILogger<Home> _logger;
    #region Dashboard
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Dashboard_Crypto()
    {
        return View();
    }

    public IActionResult Dashboard_Ecommerce() => View();


    #endregion

    #region Pages
    public IActionResult Settings()
    {
        return View();
    }
    public IActionResult Projects()
    {
        return View();
    }
    public IActionResult Clients()
    {
        return View();
    }
    public IActionResult Pricing()
    {
        return View();
    }
    public IActionResult Chat()
    {
        return View();
    }
    public IActionResult BlankPage()
    {
        return View();
    }
    #endregion
    public IActionResult Profile()
    {
        return View();
    }
    public IActionResult Invoice()
    {
        return View();
    }
    public IActionResult Tasks()
    {
        return View();
    }
    public IActionResult Calendar()
    {
        return View();
    }
    #region Auth
    public IActionResult SignIn()
    {
        return View();
    }
    public IActionResult SignUp()
    {
        return View();
    }
    public IActionResult ResetPassword()
    {
        return View();
    }
    public IActionResult _404()
    {
        return View();
    }
    public IActionResult _500()
    {
        return View();
    }
    #endregion
    #region UI Elements
    public IActionResult Alerts()
    {
        return View();
    }
    public IActionResult Buttons()
    {
        return View();
    }
    public IActionResult Cards()
    {
        return View();
    }
    public IActionResult General()
    {
        return View();
    }
    public IActionResult Grid()
    {
        return View();
    }
    public IActionResult Modals()
    {
        return View();
    }
    public IActionResult Tabs()
    {
        return View();
    }
    public IActionResult Typography()
    {
        return View();
    }
    #endregion
    #region Icons
    public IActionResult Feather()
    {
        return View();
    }
    public IActionResult FontAwesome()
    {
        return View();
    }
    #endregion
    #region Form
    public IActionResult FormLayouts()
    {
        return View();
    }
    public IActionResult BasicInputs()
    {
        return View();
    }
    public IActionResult InputGroups()
    {
        return View();
    }
    #endregion
    public IActionResult Tables()
    {
        return View();
    }
    #region Plugin
    public IActionResult FormAdvanced()
    {
        return View();
    }
    public IActionResult Editors()
    {
        return View();
    }
    public IActionResult Validation()
    {
        return View();
    }
    #endregion
    #region DataTables
    public IActionResult ResponsiveTable()
    {
        return View();
    }
    public IActionResult TableButtons()
    {
        return View();
    }
    public IActionResult ColumnSearch()
    {
        return View();
    }
    public IActionResult AjaxSourced()
    {
        return View();
    }
    #endregion
    #region Charts
    public IActionResult Chart()
    {
        return View();
    }
    public IActionResult ApexCharts()
    {
        return View();
    }
    #endregion
    public IActionResult Notifications()
    {
        return View();
    }
    #region Map
    public IActionResult GoogleMaps()
    {
        return View();
    }
    public IActionResult VectorMaps()
    {
        return View();
    }
    #endregion
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
