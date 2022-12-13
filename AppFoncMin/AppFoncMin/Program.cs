using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFoncMin
{
    class Program
    {
        /// <summary>
        /// Renvoie le plus petit chiffre parmis 3 variables
        /// </summary>
        /// <param name="nb1">Premier nombre </param>
        /// <param name="nb2">Deuxième nombre </param>
        /// <param name="nb3">Troisième nombre</param>
        /// <returns>INT le nombre minimum</returns>
        public static int UnMinimum(int nb1, int nb2, int nb3)
        {
            int nombreMinimum=0;
            
            if (nb1<=nb2 && nb1 <= nb3)
            {
                nombreMinimum = nb1;
            }
            else if (nb2<=nb1 && nb2 <= nb3)
            {
                nombreMinimum = nb2;
            }
            else
            {
                nombreMinimum = nb3;
            }
           
            return nombreMinimum;

        }
        static void Main(string[] args)
        {
            
            int nombreMini,
                nbr1,
                nbr2,
                nbr3;

            Console.Write("Nb 1 : ");
            nbr1 = int.Parse(Console.ReadLine());

            Console.Write("Nb 2 : ");
            nbr2 = int.Parse(Console.ReadLine());
            
            Console.Write("Nb 3 : ");
            nbr3 = int.Parse(Console.ReadLine());
            
            nombreMini = UnMinimum(nbr1,nbr2,nbr3);

            Console.WriteLine(nombreMini);

            Console.ReadKey();

        }
    }
}
