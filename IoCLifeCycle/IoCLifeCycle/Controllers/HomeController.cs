using IoCLifeCycle.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IoCLifeCycle.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITransient transient;
        private readonly IScoped scoped;
        private readonly ISingleton singleton;
        private readonly GuidService guidService;

        public HomeController(ILogger<HomeController> logger, ITransient transient, IScoped scoped, ISingleton singleton, GuidService guidService)
        {
            this.transient = transient;
            this.scoped = scoped;
            this.singleton = singleton;
            this.guidService = guidService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Transient = transient.Guid;
            ViewBag.Scoped = scoped.Guid;
            ViewBag.Singleton = singleton.Guid;

            /* servisten gelenler  */
            ViewBag.ServiceTransient = guidService.Transient.Guid;
            ViewBag.ServiceScoped = guidService.Scoped.Guid;
            ViewBag.ServiceSingleton = guidService.Singleton.Guid;


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
