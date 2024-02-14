using LibraryManagementAPI.Models;
using System;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace LibraryManagementAPI.Helpers.BasicAuth
{
    public class BasicAuthenticationAttribute : AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            //Used for [AllowAnonymous] Attribute
            if (SkipAuthorization(actionContext)) return;

            ValidateUser objValidateUser = new ValidateUser();

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

                    if (objValidateUser.Login(username, password)) //Returns true of false
                    {
                        //Getting user details
                        Users objUsers = objValidateUser.GetUserDetails(username, password); 
                        GenericIdentity objGenericIdentity = new GenericIdentity(username);
                        //Adding username as a Claim which can be accessed inside controller
                        objGenericIdentity.AddClaim(new Claim(ClaimTypes.Name, objUsers.u01f02));
                        IPrincipal principal = new GenericPrincipal(objGenericIdentity, objUsers.u01f04.Split(','));
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
                        CreateErrorResponse(HttpStatusCode.Unauthorized, "Username or Password is Incorrect");
                    }

                }
                catch (Exception ex)
                {
                    actionContext.Response = actionContext.Request.
                        CreateErrorResponse(HttpStatusCode.InternalServerError, "Base64Token is invalid");
                }

            }
        }
        /// <summary>
        /// To allow anonymous users to access endpoints
        /// Add [AllowAnonymous] on top of endpoint to use
        /// </summary>
        /// <param name="actionContext"></param>
        /// <returns></returns>
        private static bool SkipAuthorization(HttpActionContext actionContext)
        {
            // Use Contract.Assert to ensure that the actionContext is not null.
            Contract.Assert(actionContext != null);

            // Check if the action or controller has the AllowAnonymousAttribute.
            return actionContext.ActionDescriptor.GetCustomAttributes<AllowAnonymousAttribute>().Any()
                       || actionContext.ControllerContext.ControllerDescriptor.GetCustomAttributes<AllowAnonymousAttribute>().Any();
        }
    }
}