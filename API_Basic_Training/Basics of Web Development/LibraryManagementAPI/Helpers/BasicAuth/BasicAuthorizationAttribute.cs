using System.Net.Http;
using System.Net;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http;

namespace LibraryManagementAPI.Helpers.BasicAuth
{
    public class BasicAuthorizationAttribute: AuthorizeAttribute
    {
        protected override void HandleUnauthorizedRequest(HttpActionContext actionContext)
        {
            // Check if the user is authenticated.
            if (HttpContext.Current.User.Identity.IsAuthenticated)
            {
                // If authenticated, let the base class handle the unauthorized request
                base.HandleUnauthorizedRequest(actionContext);
            }
            else
            {
                // If not authenticated, set the response to Forbidden (403).
                actionContext.Response = new HttpResponseMessage(HttpStatusCode.Forbidden);
            }
        }
    }
}