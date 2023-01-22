using Microsoft.AspNetCore.Mvc;
using Mock5b.Models;
using System.Diagnostics;

namespace Mock5b.Controllers
{
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
        public IActionResult Calculator()
        {
            return View();
        }

        public IActionResult Result(CalculatorViewModel model)
        {
            var viewModel = new ResultViewModel();
            

            if (model.Operation == "Plus")
            {

                viewModel.Operation = model.Add;

            }

            if (model.Operation =="Minus")
            {

                viewModel.Operation = model.Minus;
            }

            if (model.Operation =="Multiply")

            {

                viewModel.Operation = model.Multiply;
            }

            if (model.Operation =="Divide")
            {

                viewModel.Operation = model.Divide;
            }
            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}