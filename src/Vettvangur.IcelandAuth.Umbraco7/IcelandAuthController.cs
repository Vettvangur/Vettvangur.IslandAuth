using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using Vettvangur.IcelandAuth.UmbracoShared;

namespace Vettvangur.IcelandAuth.Umbraco7
{
    /// <summary>
    /// /umbraco/surface/icelandAuth/Login
    /// </summary>
    public class IcelandAuthController : SurfaceController
    {
        private ControllerBehavior AuthHandler;

        public IcelandAuthController()
        {
            var log = new Log4NetLogger(LogManager.GetLogger(typeof(IcelandAuthService)));
            var icelandAuthService = new IcelandAuthService(log);
            AuthHandler = new ControllerBehavior(icelandAuthService);
        }
        public IcelandAuthController(IcelandAuthService icelandAuthService)
        {
            AuthHandler = new ControllerBehavior(icelandAuthService);
        }

        public ActionResult Login()
        {
            return Redirect(AuthHandler.Login());
        }
    }
}
