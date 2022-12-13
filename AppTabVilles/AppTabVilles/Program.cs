using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTabVilles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tab = new string[8] { "Paris", "Marseille", "Lyon", "Deauville", "Lorient", "Brest", "Lille", "Bordeaux" };
            byte choix = 10;
            string choixVille;

            do
            {
                Console.Write("Taper un nombre entre 0 et 7 compris : ");
                choix = byte.Parse(Console.ReadLine());

            } while (choix > 7 || choix < 0);

            Console.WriteLine("Nom de la ville N°" + choix + " : " + tab[choix]);

            Console.Write("Nom de la ville :");
            choixVille = Console.ReadLine();

            for (byte cpt = 0; cpt < 8; cpt++)
            {
                if (choixVille == tab[cpt])
                {
                    Console.WriteLine("Correspondance trouvée à la position : " + cpt);
                    break;
                }

                if (cpt == 7 )
                {
                    Console.WriteLine("Aucune correspondance");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
