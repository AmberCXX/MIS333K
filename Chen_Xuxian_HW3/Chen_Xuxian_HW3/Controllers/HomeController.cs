//Author: Xuxian Chen
//Date: Oct. 6, 2018
//Assignment: Fall 2018 MIS333K HW3 
//Description: MVC Tutorial.

using Microsoft.AspNetCore.Mvc;
using System;
using Chen_Xuxian_HW3.Models;
using System.Linq;

namespace Chen_Xuxian_HW3.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View("MyView");
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(guestResponse);
                return View("Thanks", guestResponse);
            }
            else
            {
                //there is a validation error
                return View(guestResponse);
            }
        }

        public ViewResult ListResponses()
        {
            return View(Repository.Responses.Where(r => r.WillAttend == true));
        }
    }
}
