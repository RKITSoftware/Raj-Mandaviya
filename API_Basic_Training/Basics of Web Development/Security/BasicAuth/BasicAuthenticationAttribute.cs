using Security.Models;
using System;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace Security.BasicAuth
{
    public class BasicAuthenticationAttribute : AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if (actionContext.Request.Headers.Authorization == null)
            {
                actionContext.Response = actionContext.Request.
                    CreateErrorResponse(HttpStatusCode.Unauthorized, "Auth Header not set");
            }
            else
            {
                try
                {
                    //Converting Authtoken into username and password
                    string authToken = actionContext.Request.Headers.Authorization.Parameter;
                    string decodedAuthToken = Encoding.UTF8.GetString(Convert.FromBase64String(authToken));

                    string[] credentials = decodedAuthToken.Split(':'); //raj:raj123

                    string username = credentials[0]; //raj
                    string password = credentials[1]; //raj123

                    if (ValidateUser.Login(username, password)) //Returns true of false
                    {
                        Users userDetails = ValidateUser.GetUserDetails(username, password); //Getting user details
                        GenericIdentity identity = new GenericIdentity(username);
                        identity.AddClaim(new Claim(ClaimTypes.Name, userDetails.Username));
                        IPrincipal principal = new GenericPrincipal(identity, userDetails.Role.Split(','));
                        Thread.CurrentPrincipal = principal;

                        if (HttpContext.Current != null)
                        {
                            HttpContext.Current.User = principal;
                        }
                        else
                        {
                            actionContext.Response = actionContext.Request.
                            CreateErrorResponse(HttpStatusCode.Unauthorized, "Auth Denied");
                        }
                    }
                    else
                    {
                        actionContext.Response = actionContext.Request.
                        CreateErrorResponse(HttpStatusCode.Unauthorized, "Login Failed from validateuser");
                    }

                }
                catch (Exception ex)
                {
                    actionContext.Response = actionContext.Request.
                        CreateErrorResponse(HttpStatusCode.InternalServerError, "Base64Token is invalid");
                }

            }

        }
    }
}