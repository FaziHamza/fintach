using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fintech.Controllers
{
    public class UserLoginController : Controller
    {
        public IActionResult Trade()
        {
            return View();
        }

        public IActionResult PaymentMethod() {

            return View();
        
        }

        public IActionResult Pay() {

            return View();
        
        }

        public IActionResult Invoice() {

            return View();
        
        }
    }
}
