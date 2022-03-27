using Lab1.Models;
using Lab1.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lab1.Controllers
{
    public class CalcServiceController : Controller
    {
        private CalcService _calcService = new CalcService();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PassUsingModel()
        {
            return View(_calcService.GetCalcModel());
        }
        public IActionResult PassUsingViewData()
        {
            var model = _calcService.GetCalcModel();
            ViewData["FirstValue"] = model.FirstValue;
            ViewData["SecondValue"] = model.SecondValue;
            ViewData["CalcResults"] = model.CalcResults;
            return View();
        }
        public IActionResult PassUsingViewBag()
        {
            var model = _calcService.GetCalcModel();
            ViewBag.FirstValue = model.FirstValue;
            ViewBag.SecondValue = model.SecondValue;
            ViewBag.CalcResults = model.CalcResults;
            return View();
        }
        public IActionResult AccessServiceDirectly()
        {
            return View();
        }
    }
}
