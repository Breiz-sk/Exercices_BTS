using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMajeur
{
    class Program
    {
        static void Main(string[] args)
        {
            byte age ;
            string ageStr;

            Console.WriteLine("Votre age : ");
            ageStr = Console.ReadLine();
            age = byte.Parse(ageStr);
            Console.WriteLine(age);
            
            if (age >= 18)
            {    
                Console.WriteLine("Majeur");
                if (age > 65)
                {
                    Console.WriteLine("Senior");
                }
            }
            
            else
            {
                Console.WriteLine("Mineur");
            }
            ageStr = Console.ReadLine();
        }
    }
}
