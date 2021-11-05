using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using pamukkaleEdu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace pamukkaleEdu.API.Security
{
    public class BasicAuthenticationHandler : AuthenticationHandler<BasicAuthenticationOption>
    {
        public BasicAuthenticationHandler(IOptionsMonitor<BasicAuthenticationOption> options, ILoggerFactory factory, UrlEncoder encoder, ISystemClock clock):base(options, factory, encoder,  clock )
        {

        }
        protected override Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if (!Request.Headers.ContainsKey("Authorization"))
            {
                return Task.FromResult(AuthenticateResult.NoResult());
            }

            if (!AuthenticationHeaderValue.TryParse(Request.Headers["Authorization"],out AuthenticationHeaderValue value))
            {
                return Task.FromResult(AuthenticateResult.NoResult());
            }

            if (!value.Scheme.Equals("Basic", StringComparison.OrdinalIgnoreCase))
            {
                return Task.FromResult(AuthenticateResult.NoResult());

            }

            byte[] bytes = Convert.FromBase64String(value.Parameter);
            string credential = Encoding.UTF8.GetString(bytes);
            //username:1234
            var splitted = credential.Split(':');
            var username = splitted[0];
            var pass = splitted[1];

            //userService vs yazmaya üşendiğim için burada sahte denetim yaptım :(
            if (username=="admin" && pass =="1234")
            {
                //normalde, IUserService interface'ini implemente eden bir sınıfın instance'i burada Validasyon yapmalı.
                User user = new User { Name = "turkay", Role = "Yonetici" };

                List<Claim> claims = new List<Claim>
                {

                    new Claim(ClaimTypes.Name, user.Name),
                    new Claim(ClaimTypes.Role, user.Role),

                };

                ClaimsIdentity identity = new ClaimsIdentity(claims, Scheme.Name);
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);
                AuthenticationTicket authenticationTicket = new AuthenticationTicket(claimsPrincipal, Scheme.Name);
                return Task.FromResult(AuthenticateResult.Success(authenticationTicket));

            }

            return Task.FromResult(AuthenticateResult.Fail("Kullanıcı adı veya şifre yanlış"));
                


        }
    }
}
