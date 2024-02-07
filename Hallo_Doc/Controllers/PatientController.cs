using Hallo_Doc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Hallo_Doc.Controllers
{
    public class PatientController : Controller
    {
        private readonly ILogger<PatientController> _logger;

        public PatientController(ILogger<PatientController> logger)
        {
            _logger = logger;
        }

        public IActionResult Site()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Reset()
        {
            return View();
        }
        public IActionResult Request()
        {
            return View();
        }
        public IActionResult Patients()
        {
            return View();
        }
        public IActionResult Family()
        {
            return View();
        }
        public IActionResult Concierge()
        {
            return View();
        }
        public IActionResult Business()
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