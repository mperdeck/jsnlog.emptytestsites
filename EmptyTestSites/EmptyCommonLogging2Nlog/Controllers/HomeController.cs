using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Common.Logging;

namespace EmptyCommonLogging2Nlog.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ILog log = LogManager.GetLogger("Server Logger");
            log.Debug("Warn Message generated on server");

            return View();
        }
    }
}
