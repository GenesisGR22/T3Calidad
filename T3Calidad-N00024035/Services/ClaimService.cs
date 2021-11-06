using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T3Calidad_N00024035.Models;

namespace T3Calidad_N00024035.Services
{
    public interface IClaimService
    {
        Usuario LoggedUser();
        void SetHttpContext(HttpContext httpContext);
    }
    public class ClaimService: IClaimService
    {
        private IN00024035Context context;
        private HttpContext httpContext;

        public ClaimService(IN00024035Context context)
        {
            this.context = context;

        }
        public void SetHttpContext(HttpContext httpContext)
        {
            this.httpContext = httpContext;
        }
        public Usuario LoggedUser()
        {
            var claim = httpContext.User.Claims.FirstOrDefault();

            try
            {
                var user = context.Usuarios.Where(o => o.Nombre == claim.Value).FirstOrDefault();
                return user;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }
}
