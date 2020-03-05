using System;

namespace Quiz8
{
    class Program
    {

        static void Main(string[] args)
        {
            AutoProper R = new AutoProper { Name = "Rifle", Sound = "Bang", Caliper = "9 mm" };
            AutoProper P = new AutoProper { Name = "Pistol", Sound = "Pop", Caliper = "7.62 mm" };
            AutoProper S = new AutoProper { Name = "Shotgun", Sound = "Bang", Caliper = "12 Gauge" };

         
            Console.WriteLine("This is C Sharp quiz 8");
            Console.WriteLine($"I am a {R.Name}, and I go {R.Sound} with a {R.Caliper}, we have {R.Firearm(1)} firearms" );
            Console.WriteLine($"I am a {P.Name}, and I go {P.Sound} with a {P.Caliper}, we have {P.Firearm(1)+1} firearms");
            Console.WriteLine($"I am a {S.Name}, and I go {S.Sound} with a {S.Caliper}, we have {S.Firearm(1)+2} firearms");

        }
    }
}
