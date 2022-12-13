using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProduitTab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[8] { 4, 8, 7, 9, 1, 5, 4, 6 }; 
            //76521374
            int[] tab2 = new int[8] { 7, 6, 5, 2, 1, 3, 7, 4 };
            // 7 6 5 2 1 3 7 4

            int[] tab4 = new int[8];

            for (byte cpt= 0; cpt <= 7; cpt++)
            {
                tab4[cpt] = tab[cpt] * tab2[cpt];
                Console.WriteLine(tab4[cpt]);
            }

            //int[] tab3 = new int[8] { 28, 48, 35, 18, 1, 15, 28, 24 }; 
            //28 48 35 18 1 15 28 24 
            Console.ReadKey();
                
        }
    }
}
