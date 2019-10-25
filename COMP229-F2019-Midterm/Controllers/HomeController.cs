using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using COMP229_F2019_Midterm.Models;

namespace COMP229_F2019_Midterm.Controllers
{
    public class HomeController : Controller
    {
        // default action method
        public ViewResult Index()
        {
            return View();
        }
    }
}
