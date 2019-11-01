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
        /// <summary>
        /// This method returns CarRegistrationForm view (GET)
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ViewResult CarRegistrationForm()
        {
            return View();
        }
        /// <summary>
        /// This method is used to save the new car into the CarList (POST)
        /// </summary>
        /// <param name="patient"></param>
        /// <returns></returns>
        [HttpPost]
        public ViewResult CarRegistrationForm(Car car)
        {
            if (ModelState.IsValid)
            {
                Repository.AddCar(car);
                return View("Thanks", car);
            }
            else
            {
                return View();
            }
        }
        /// <summary>
        /// This method returns CarList view
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ViewResult CarList()
        {
            return View(Repository.CarList.OrderBy(c => c.OwnerName));
        }
    }
}
