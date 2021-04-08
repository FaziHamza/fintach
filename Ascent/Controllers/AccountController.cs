using Entities;
using Fintech.Helper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Services;
using Services.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fintech.Controllers
{
    public class AccountController : Controller
    {
        private IWebHostEnvironment webHostEnvironment;
        private readonly IConfiguration _config;
        private readonly AscentContext _db;
        public AccountController(IWebHostEnvironment webHostEnvironment, IConfiguration config, AscentContext db)
        {
            this.webHostEnvironment = webHostEnvironment;
            _config = config;
            _db = db;
        }
        public IActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registration(tblUser user)
        {
            Users.AddUser(user, user.tblContactInfoAccountDetails, user.tblContactInfoBusiness, user.tblIdentifiaction, user.tblLegalInfo, user.tblResidence, user.tblSecure);
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(tblUser user)
        {
            bool result = Users.Login(user);
            if (result == true)
            {
                //_appConfig.SetName(user.tblIdentifiaction.Name);
                SetSession(user);
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                ViewBag.Error = "Invalid Email and/or password !";
            }
            return View();
        }
        public void SetSession(tblUser user)
        {
            HttpContext.Session.SetString("UserId", user.UserId.ToString());
            HttpContext.Session.SetString("UserName", user.tblIdentifiaction.Name);
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}
