using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using EscuelasWebApi;
using EscuelasWebApi.Models;
using Microsoft.Owin.Security.OAuth;

[assembly: OwinStartup(typeof(EscuelasWebApi.StartUp))]
namespace EscuelasWebApi
{ 
    public class StartUp
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureOAuth(app);
            HttpConfiguration config = new HttpConfiguration();
            WebApiConfig.Register(config);
            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);
            app.UseWebApi(config);
            


        }

        public void ConfigureOAuth(IAppBuilder app)
        {
            OAuthAuthorizationServerOptions OAuthServerOptions = new OAuthAuthorizationServerOptions()
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/Token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(1),
                Provider = new SimpleAuthorizationServerProvider() //aca iba SimpleAuthorizationServerProvider
            };

            // Token Generation
            app.UseOAuthAuthorizationServer(OAuthServerOptions);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());

        }

    }

    public class SimpleAuthorizationServerProvider : OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            try
            {
                var userEmail = context.Request.ReadFormAsync().Result.Get("email");

                context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });

                using (var authRepository = new AuthRepository())
                {
                    if (userEmail != null)
                    {
                        var user = await authRepository.FindUser(userEmail, context.Password);

                        if (user == null)
                        {
                            context.SetError("invalid_grant", "Usuario o contraseña invalidos.");
                            return;
                        }

                    }
                    else
                    {
                        context.SetError("invalid_grant", "email no encontrado en la request. vieja!.");
                        return;
                    }

                }

                var identity = new ClaimsIdentity(context.Options.AuthenticationType);
                identity.AddClaim(new Claim("sub", userEmail));
                identity.AddClaim(new Claim("role", "admin"));
                identity.AddClaim(new Claim(ClaimTypes.Name, userEmail));

                context.Validated(identity);
            }
            catch (Exception ex)
            {

                throw;
            }



        }
    }
}