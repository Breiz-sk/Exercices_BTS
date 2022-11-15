using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCalculette
{
    class Program
    {
        static void Main(string[] args)
        {
            string 
                operation, 
                Temp;
            
            int nombre1, 
                nombre2,
                reste;
            
            Boolean afficher = true;

            Console.WriteLine("Nbre 1 :");
            Temp = Console.ReadLine();
            nombre1 = int.Parse(Temp);
            
            Console.WriteLine("Nbre 2 :");
            Temp = Console.ReadLine();
            nombre2 = int.Parse(Temp);

            Console.WriteLine("Type opération (+,-,/,*) : ");
            operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    nombre1 = nombre1 + nombre2;
                    break;
                case "-":
                    nombre1 = nombre1 - nombre2;
                    break;
                case "*":
                    nombre1 = nombre1 * nombre2;
                    break;
                case "/": 
                    if (nombre2 == 0)
                    {
                        Console.WriteLine("Division par 0 ");
                        break;
                    }
                    else
                    {
                        reste = nombre1 % nombre2;
                        nombre1 = nombre1 / nombre2;
                        Console.WriteLine(nombre1);
                        afficher = false;
                        break;
                    }
                default:
                    Console.WriteLine("Signe non connu");
                    break; 

            }
            if (afficher)
            {
                Console.WriteLine(nombre1);
            }  
            Console.ReadKey();

        }
    }
}
