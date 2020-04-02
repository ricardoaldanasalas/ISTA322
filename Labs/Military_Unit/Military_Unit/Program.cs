using System;

namespace Military_Unit
{
    class Program
    {
        static void Main(string[] args)
        {
            Personnel A = new Personnel { Name = "Ricardo", Rank = "SGT", Location = "Quantico" };
            Personnel B = new Personnel { Name = "Michael", Rank = "SSG", Location = "Fort Bragg" };
            Personnel Be = new Personnel { Name = "James", Rank = "SGT", Location = "Quantico" };
            Console.WriteLine($"Names is {A.Name}, My Rank is {A.Rank} and I am located in {A.Location}");
            Console.WriteLine($"Names is {B.Name}, My Rank is {B.Rank} and I am located in {B.Location}");
            Console.WriteLine($"Names is {Be.Name}, My Rank is {Be.Rank} and I am located in {Be.Location}");

            Missions Aa = new Missions { Name = "Eagles", DeadLine = "0800", Location = "Korea" };
            Missions Bb = new Missions { Name = "HashBack", DeadLine = "2000", Location = "Fort Bragg" };
            Missions c = new Missions { Name = "Zellow", DeadLine = "2300", Location = "Quantico" };
            Console.WriteLine($"Mission is {Aa.Name}, My DeadLine is {Aa.DeadLine} and I am located in {Aa.Location}");
            Console.WriteLine($"Misssion is {Bb.Name}, My DeadLine is {Bb.DeadLine} and I am located in {Bb.Location}");
            Console.WriteLine($"Mission is {c.Name}, My DeadLine is {c.DeadLine} and I am located in {c.Location}");

            Vehicles V = new Vehicles { Make = "MATV", Model = "1028C", Type = "Ground Vehicle" };
            Console.WriteLine($"I Am a {V.Make}, My Model is {V.Model} and I am a {V.Type}");


        }
    }
    class Personnel
    { 
        public string Name { get; set; }
        public string Rank { get; set; }
        public string Location { get; set; }
    }
    class Missions
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string DeadLine { get; set; }
    }
    class Vehicles
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
    }


}
