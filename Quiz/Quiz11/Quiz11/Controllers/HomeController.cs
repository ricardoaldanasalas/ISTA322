using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Quiz11.Models;

namespace Quiz11.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            List<string> family = new List<string>();
            foreach (Person p in People.Person())
            {
                string Fname = p.Fname;
                string gender = p.Gender;
                string Lname = p.Lname;
                string Country = p.Country;
                family.Add(string.Format("Hello! Name is {0} and last name is {1}, I am a {2} and I am from {3} ", Fname,Lname, gender, Country));
            }
            return View(family);
        }

    }
}
