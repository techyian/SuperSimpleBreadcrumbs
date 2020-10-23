using Microsoft.AspNetCore.Mvc;
using SuperSimpleBreadcrumbs.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperSimpleBreadcrumbs.Controllers
{
    [BreadcrumbActionFilter]
    public class BaseController : Controller
    {
    }
}
