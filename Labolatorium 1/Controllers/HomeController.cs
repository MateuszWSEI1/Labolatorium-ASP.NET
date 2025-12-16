using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Labolatorium_1.Models;

namespace Labolatorium_1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }

    public enum Operator
    {
        Unknown,
        Add,
        Mul,
        Sub,
        Div
    }
    public IActionResult Calculator(double? a, double? b, Operator op)
    {
        ViewBag.A = a;
        ViewBag.B = b;
        ViewBag.Op = op;

        double? result = null;

        if (a.HasValue && b.HasValue)
        {
            switch (op)
            {
                case Operator.Add:
                    result = a.Value + b.Value;
                    break;

                case Operator.Sub:
                    result = a.Value - b.Value;
                    break;

                case Operator.Mul:
                    result = a.Value * b.Value;
                    break;

                case Operator.Div:
                    if (b.Value != 0)
                        result = a.Value / b.Value;
                    break;

                default:
                    result = null;
                    break;
            }
        }

        ViewBag.Result = result;
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}