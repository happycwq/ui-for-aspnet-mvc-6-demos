﻿using Microsoft.AspNet.Mvc;

namespace Kendo.Mvc.Examples.Controllers
{
	public partial class GridController : Controller
    {
        public ActionResult Filter_Row()
        {
            ViewData["initial"] = productService.Read();
            return View();
        }
    }
}