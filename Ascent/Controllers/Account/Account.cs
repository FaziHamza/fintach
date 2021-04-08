using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fintech.Controllers.Account
{
    public class Account : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
