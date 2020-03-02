using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;
using System.Linq;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            //return "hello MSSA";
            int hour = DateTime.Now.Hour;
            //ternary operator
            string greeting;
            if (hour < 12)
                greeting = "Good Morning";
            else if (hour < 16)
                greeting = "Good Afternoon";
            else
                greeting = "Good Evening";
            ViewBag.Greeting = greeting;
            ViewBag.Fairy = "Tinkerbel";
            ViewBag.Cyborg = " Terminator";
            //returns View();
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
                // there is a validation error
                return View();
            }
        }
        public ViewResult ListResponses()
        {
            return View(Repository.Responses.Where(r => r.WillAttend == true));
        }
    }
}