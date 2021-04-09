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
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Fintech.Controllers
{
    public class AccountController : Controller
    {
        private IWebHostEnvironment _webHostEnvironment;
        private readonly IConfiguration _config;
        private readonly AscentContext _db;
#pragma warning disable CS0618 // 'IHostingEnvironment' is obsolete: 'This type is obsolete and will be removed in a future version. The recommended alternative is Microsoft.AspNetCore.Hosting.IWebHostEnvironment.'
        private readonly IHostingEnvironment _appEnvironment;
#pragma warning restore CS0618 // 'IHostingEnvironment' is obsolete: 'This type is obsolete and will be removed in a future version. The recommended alternative is Microsoft.AspNetCore.Hosting.IWebHostEnvironment.'
#pragma warning disable CS0618 // 'IHostingEnvironment' is obsolete: 'This type is obsolete and will be removed in a future version. The recommended alternative is Microsoft.AspNetCore.Hosting.IWebHostEnvironment.'
        public AccountController(IWebHostEnvironment webHostEnvironment, IHostingEnvironment appEnvironment, IConfiguration config, AscentContext db)
#pragma warning restore CS0618 // 'IHostingEnvironment' is obsolete: 'This type is obsolete and will be removed in a future version. The recommended alternative is Microsoft.AspNetCore.Hosting.IWebHostEnvironment.'
        {
            _webHostEnvironment = webHostEnvironment;
            _config = config;
            _db = db;
            _appEnvironment = appEnvironment;
        }
        public IActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registration(tblUser user , IFormFile files1, IFormFile FilePath2, IFormFile FilePath, IFormFile FilePath3, IFormFile FilePath1, IFormFile BusinessLogo)
        {
            if(files1!=null)
            {
                var file = UpdaloadFileToserverAsync(files1);
                user.tblContactInfoAccountDetails.FilePath = file;
            }
           if(FilePath!=null)
            {
                var path = UpdaloadFileToserverAsync(FilePath);
                user.tblIdentifiaction.FilePath = path;
            }
            if(FilePath1 != null)
            {
                var files2 = UpdaloadFileToserverAsync(FilePath1);
                user.tblLegalInfo.FilePath1 = files2;
            }
            if(FilePath2 != null)
            {
                var path2 = UpdaloadFileToserverAsync(FilePath2);
                user.tblLegalInfo.FilePath2 = path2;
            }
            if(FilePath3 != null)
            {
                var path3 = UpdaloadFileToserverAsync(FilePath3);
                user.tblLegalInfo.FilePath3 = path3;
            }
            if(BusinessLogo != null)
            {
                var blogo = UpdaloadFileToserverAsync(BusinessLogo);
                user.tblLegalInfo.BusinessLogo = blogo;
            }
            
            Users.AddUser(user, user.tblContactInfoAccountDetails, user.tblContactInfoBusiness, user.tblIdentifiaction, user.tblLegalInfo, user.tblResidence, user.tblSecure);
            return View();
        }

        private string UpdaloadFileToserverAsync(IFormFile file)
        {
            string path_Root = _appEnvironment.WebRootPath;
            string filename = file.FileName;
            string filepath = path_Root + "//images";
            string path_to_Images_toDb = "\\images" + Guid.NewGuid() + file.FileName;

            string path_to_Images = path_Root + path_to_Images_toDb;
            using (var stream = new FileStream(path_to_Images, FileMode.Create))
            {
                file.CopyToAsync(stream);
            }
            return path_to_Images_toDb;
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
