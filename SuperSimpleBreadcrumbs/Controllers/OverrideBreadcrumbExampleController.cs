﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperSimpleBreadcrumbs.Controllers
{
    public class OverrideBreadcrumbExampleController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
