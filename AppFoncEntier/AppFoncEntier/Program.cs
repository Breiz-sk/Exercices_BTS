using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFoncEntier
{
    class Program
    {
        /// <summary>
        /// Détermine le statut d'une variable
        /// </summary>
        /// <returns> Renvoie la valeur de l'utilisateur</returns>
        public static int UnEntier()
        {
            int valeur=0;
            string strValeur="";
            Console.WriteLine("Saisir un entier : ");
            strValeur = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("Saisir un entier : ");
                strValeur = Console.ReadLine();

                if ((int.TryParse(strValeur, out valeur) == true) && (valeur <= 255 && valeur >= 0))
                {
                    Console.WriteLine("la valeur saisie est bien un ENTIER");
                    break;
                }
                else if (valeur > 255 || valeur < 0)
                {
                    Console.WriteLine("la valeur saisie n’est pas comprise entre 0 et 255");
                }
                else
                {
                    Console.WriteLine("la valeur saisie n’est pas un ENTIER");
                }
            }
            
            return valeur;
        }


        static void Main(string[] args)
        {
            UnEntier();
            Console.ReadKey();

        }
    }
}
