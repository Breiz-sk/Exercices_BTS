using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFoncTabMin
{
    class Program
    {
        /// <summary>
        /// Renvoie le plus petit chiffre parmis un tableau d'entiers
        /// </summary>
        /// <param name="tabEntiers">Premier nombre </param>
        /// <returns>INT le nombre minimum</returns>
        public static int UnMinimumTab(int[] tabEntiers)
        {
            int nombreMinimum = tabEntiers[0];

            for (byte cpt=1;cpt<tabEntiers.Length;cpt++)
            {
                if (nombreMinimum > tabEntiers[cpt])
                {
                    nombreMinimum = tabEntiers[cpt];
                }
            }

            return nombreMinimum;

        }
        static void Main(string[] args)
        {

            int[] tabEntier = new int[] { 12, 8, 15, 10, 18, 1, 20, 2, 9, 19 };
            int nombreMini;

            nombreMini = UnMinimumTab(tabEntier);

            Console.WriteLine("La valeur min du tableau est : "+nombreMini);

            Console.ReadKey();

        }
    }
}