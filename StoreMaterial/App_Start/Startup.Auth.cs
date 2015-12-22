using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;

namespace StoreMaterial
{
    public partial class Startup
    {
        // For more information on configuring authentication, please visit http://go.microsoft.com/fwlink/?LinkId=301864
        public void ConfigureAuth(IAppBuilder app)
        {
            var cookieOptions = new CookieAuthenticationOptions()
            {
                LoginPath = new PathString("/Account/Login")
            };
            app.UseCookieAuthentication(cookieOptions);
        }
    }
}