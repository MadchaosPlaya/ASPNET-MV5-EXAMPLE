using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie1.Controllers
{
    public class HelloworldController : Controller
    {
        //
        // GET: /Helloworld/

        public ActionResult Index()
        {
		    return View();
	    }

		//
		// GET: / Helloworld/

		public ActionResult Welcome(string Connor, int numtimes = 1)
		{
		    ViewBag.Message = "Hello " + Connor; 
			ViewBag.Numtimes = numtimes;

            return View();
        }

	}
}


	

	


