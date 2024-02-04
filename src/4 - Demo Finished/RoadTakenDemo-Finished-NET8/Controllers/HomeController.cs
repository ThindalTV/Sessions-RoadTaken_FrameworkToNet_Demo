using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using RoadTakenDemo.Finished.Abstractions;
using RoadTakenDemoTemplate.Models;

namespace RoadTakenDemoTemplate.Controllers;

public class HomeController : Controller
{
    private IDemoFacade _demoFacade;
    private Config _config;

    public HomeController(IDemoFacade demoFacade, IOptions<Config> options)
    {
        _demoFacade = demoFacade;
        _config = options.Value;
    }

    // GET: Home
    [HttpGet]
    public ActionResult Index()
    {
        var model = new DemoModel();
        model.FirstNumber = _config.FirstNumber;

        return View(model);
    }

    [HttpPost]
    public ActionResult Index(string num1, string num2)
    {
        var iNum1 = Int32.Parse(num1);
        var iNum2 = Int32.Parse(num2);

        var model = _demoFacade.AddNumbers(iNum1, iNum2);

        return View(model);
    }
}