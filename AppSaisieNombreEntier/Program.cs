using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSaisieNombreEntier
{
    class Program
    {
        static void Main(string[] args)
        {
            int valeur;
            string strValeur;
            

            Console.Write("SAISIR UN ENTIER : ") ;
            strValeur = Console.ReadLine();
            
            while (int.TryParse(strValeur, out valeur)==false ) 
            {
                Console.WriteLine("La valeur saisie n'est pas un ENTIER") ;
                Console.Write("SAISIR UN ENTIER : ") ;
                strValeur = Console.ReadLine();
            }
            Console.WriteLine("La valeur saisie est bien un ENTIER") ;
            
            

        }
    }
}