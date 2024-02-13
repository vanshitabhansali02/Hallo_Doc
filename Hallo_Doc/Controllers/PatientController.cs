using BusinessLogic.Interfaces;
using BusinessLogic.Services;
using DataAccess.DataContext;
using DataAccess.ViewModel;
using Hallo_Doc.Models;
using Hallo_Doc.Views.Patient;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Hallo_Doc.Controllers
{
    public class PatientController : Controller
    {
        private readonly ILogger<PatientController> _logger;
        private readonly ILoginService _loginService;
        private readonly IRequestService _reqservice;
        private readonly ApplicationDbContext _db;

        
        public PatientController(ILogger<PatientController> logger,ILoginService loginService,IRequestService requestservice,ApplicationDbContext db)
        {
            _logger = logger;
            _loginService = loginService;
            _reqservice = requestservice;
            _db = db;
        }
        [HttpPost]
        public IActionResult Login(LoginUser loginuser)
        {
            if (ModelState.IsValid)
            {
                if (_loginService.LoginData(loginuser))
                {
                    // User is valid, perform login logic
                    TempData["message"] = "Valid User";
                    return RedirectToAction("Site", "Patient");

                }
                else
                {
                    TempData["message"] = "invalid";
                }

                // Invalid user, handle accordingly (e.g., show error message)

            }
            return RedirectToAction("Family", "Patient");


        }
        [HttpPost]

        public IActionResult Patients(PatientReq patientreqmodel) {
            
            _reqservice.PatientData(patientreqmodel);   
                return RedirectToAction("Family", "Patient");
        }
        [HttpPost]

        public IActionResult Family(PatientReq patientreqmodel)
        {

            _reqservice.PatientData(patientreqmodel);
            return RedirectToAction("Family", "Patient");
        }

        [HttpPost]
 public IActionResult Business(BusinessReq businessreqmodel)
        {

            _reqservice.BusinessData(businessreqmodel);
            return RedirectToAction("Family", "Patient");
        }
        public JsonResult CheckEmailExists(string email)
        {
            bool emailExists = _db.Aspnetusers.Any(u => u.Email == email);
            return Json(new { emailExists = emailExists });
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