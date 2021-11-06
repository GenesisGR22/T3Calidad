using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T3Calidad_N00024035.Models;

namespace T3Calidad_N00024035.Controllers
{
    public class BaseController : Controller
    {
        private readonly N00024035Context context;
        public BaseController(N00024035Context context)
        {
            this.context = context;
        }

        protected Usuario LoggedUser()
        {
            var claim = HttpContext.User.Claims.FirstOrDefault();
            var user = context.Usuarios.Where(o => o.Nombre == claim.Value).FirstOrDefault();
            return user;
        }
    }
}
