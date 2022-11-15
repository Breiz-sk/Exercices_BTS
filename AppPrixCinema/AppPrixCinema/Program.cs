using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPrixCinema
{
    class Program
    {
        static void Main(string[] args)
        {
            byte age, age2 ;
            string ageStr;

            Console.WriteLine("Age 1 : ");
            ageStr = Console.ReadLine();
            age = byte.Parse(ageStr);
           
            Console.WriteLine("Age 2 : ");
            ageStr = Console.ReadLine();
            age2 = byte.Parse(ageStr);

            if (age < 18 && age2 < 18)
            {
                Console.WriteLine("14€ en tout");
            }
            
            else if ( (age < 18 && age2 >= 18) || (age >= 18 && age2 < 18) )
            {
                Console.WriteLine("15€ en tout");
            }

            else
            {
                Console.WriteLine("18€ en tout");
            }

        }
    }
}
