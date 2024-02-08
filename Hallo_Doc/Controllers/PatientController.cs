﻿using BusinessLogic.Interfaces;
using BusinessLogic.Services;
using DataAccess.DataModels;
using DataAccess.DataModels.Custom_Model;
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
        public PatientController(ILogger<PatientController> logger,ILoginService loginService)
        {
            _logger = logger;
            _loginService = loginService;
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
        [HttpPost]
        public IActionResult Login(LoginUser model)
        {
            if (_loginService.LoginUser(model.Email, model.Password))
            {
                // User is valid, perform login logic
                return RedirectToAction("Site", "Patient");

            }
            else
            {
                // Invalid user, handle accordingly (e.g., show error message)
                return RedirectToAction("Login", "Patient");

            }
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}