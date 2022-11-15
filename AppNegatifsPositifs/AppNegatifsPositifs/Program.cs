using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNegatifsPositifs
{
    class Program
    {
        static void Main(string[] args)
        {
            int nombre = 0, cptPositif=0, cptNegatif=0, Somme = 0;
            double moyenne = 0;
            string nombreStr;

            do
            {
                Console.Write("Saisir 0 pour terminer: ");
                //nombreStr = Console.ReadLine();
                //nombre = int.Parse(nombreStr);
                nombre = int.Parse(Console.ReadLine());
                Console.WriteLine(nombre);
                if (nombre > 0)
                {
                    cptPositif++;
                    moyenne += nombre;

                }
                else
                {
                    cptNegatif++;
                    Somme += nombre;

                }
            } while (nombre != 0);
            moyenne /= cptPositif;
            //moyenne2 /= cptNegatif;
            Console.WriteLine("Moyenne nombre positifs : "+moyenne);
            //Console.WriteLine("Moyenne nombre négatifs : " + moyenne2);
            Console.WriteLine("Somme nombre négatifs : " + Somme);
            Console.WriteLine("fin du programme");
            Console.ReadKey();
        }
    }
}
