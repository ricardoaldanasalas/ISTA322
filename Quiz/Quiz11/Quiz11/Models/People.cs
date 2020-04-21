using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz11.Models
{
    public class People
    {
        public static Person[] Person()
        {
            Person Ricardo = new Person { Fname = "Ricardo", Gender = "Male", Lname = "AldanaSalas", Country = "Bolivia" };
            Person Ana = new Person { Fname = "Ana", Gender = "Female", Lname = "AldanaSalas", Country = "Bolivia" };
            Person Giovanna = new Person { Fname = "Giovanna", Gender = "Female", Lname = "AldanaSalas", Country = "Bolivia" };
            Person Roxanna = new Person { Fname = "Roxanna", Gender = "Female", Lname = "Salas", Country = "Bolivia" };
            Person Andres = new Person { Fname = "Andres", Gender = "Male", Lname = "Veliz", Country = "USA" };
            return new Person[] { Ricardo,Ana,Giovanna,Roxanna,Andres };
        }
    }
}
