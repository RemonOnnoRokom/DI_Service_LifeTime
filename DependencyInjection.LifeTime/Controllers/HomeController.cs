using System.Diagnostics;
using DependencyInjection.LifeTime.Models;
using LifeTime.Services.IService;
using LifeTime.Services.Service;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.LifeTime.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISingleton _singleton1;
        private readonly ISingleton _singleton2;
        private readonly ITransient _transient1;
        private readonly ITransient _transient2;
        private readonly IScoped _scoped1;
        private readonly IScoped _scoped2;

        public HomeController(ILogger<HomeController> logger,ISingleton singleton1, ISingleton singleton2,
            ITransient transient1, ITransient transient2, IScoped scoped1, IScoped scoped2)
        {
            _logger = logger;
            _singleton1 = singleton1;
            _singleton2 = singleton2;
            _scoped1 = scoped1;
            _scoped2 = scoped2;
            _transient2 = transient2;
            _transient1 = transient1;
        }

        public IActionResult Index()
        {
            Console.Clear();
            Console.WriteLine($"Singleton-1 : {_singleton1.GetGuId()}");
            Console.WriteLine($"Singleton-2 : {_singleton2.GetGuId()}");
            Console.WriteLine("\n\n");
            Console.WriteLine($"transient-2 : {_transient2.GetGuId()}");
            Console.WriteLine($"transient-1 : {_transient1.GetGuId()}");
            Console.WriteLine("\n\n");
            Console.WriteLine($"scoped-1 : {_scoped1.GetGuId()}");
            Console.WriteLine($"scoped-2 : {_scoped2.GetGuId()}");
            
            return View();
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
