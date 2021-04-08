using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fintech.Helper
{
    public class AppConfig
    {
        public readonly IHttpContextAccessor _context;
        public AppConfig(IHttpContextAccessor contextAccessor)
        {
            _context = contextAccessor;
        }

        public Int64 Id
        {
            get
            {
                
                return _context.HttpContext.Session.GetInt32("UserId") != null ? Convert.ToInt32(_context.HttpContext.Session.GetInt32("UserId")) : 0;
            }
        }
    }
}
