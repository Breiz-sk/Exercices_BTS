using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTableMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int
                resultat,
                nombre;
        
           
            Console.Write("Choisir une table : ");
            nombre = int.Parse(Console.ReadLine());
            
            for (byte cpt = 0; cpt <= 10; cpt++)
            {
                resultat = nombre * cpt;
                Console.WriteLine(nombre + "x" + cpt + "=" + resultat);
            }
            Console.ReadKey();
        }
    }
}
