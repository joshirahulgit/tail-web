using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace TailApi.Application.Controllers
{
    //public static class ControllerExt
    //{
    //    internal static T GetService<T>(this ApiController controller) where T : IContract
    //    {
    //        T service = ServiceFactory<T>.New;

    //        if (!(controller is AuthController))
    //        {
    //            var jwtClaim = GetAuthorizationToken(controller);
    //            //TODO handle token validation here or make sure call doesn't reach here.
    //            //if (jwtClaim == null)
    //            //    return ;

    //            IRequestContext reqContext = new RequestContext(jwtClaim.usr, jwtClaim.accid, jwtClaim.accname, "", "", "");

    //            service.RequestContext = reqContext;
    //        }

    //        return service;
    //    }

    //    internal static IAuthenticationService AuthenticationService(this ApiController controller)
    //    {
    //        return controller.GetService<IAuthenticationService>();
    //    }

    //    internal static IAccountService AccountService(this ApiController controller)
    //    {
    //        return controller.GetService<IAccountService>();
    //    }

    //    internal static ICptService CptService(this ApiController controller)
    //    {
    //        return controller.GetService<ICptService>();
    //    }

    //    internal static JwtClaimModel GetAuthorizationToken(this ApiController controller)
    //    {
    //        var beaverToken = controller.Request.Headers.GetValues("Authorization").FirstOrDefault();
    //        if (string.IsNullOrEmpty(beaverToken))
    //            return null;

    //        var tokens = beaverToken.Split(' ');
    //        if (tokens.Count() < 2)
    //            return null;

    //        var jwtClaim = JwtHelper.GetJwtClaimModel(tokens[1]);

    //        return jwtClaim;
    //    }
    //}
}