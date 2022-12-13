using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMoyenneMatiere
{
    class Program
    {
        static void Main(string[] args)
        {
            float
                moyenne=0,
                somme=0;

            for (byte cpt=1; cpt<=6 ; cpt++)
            {
                Console.Write("Saisir la note " + cpt + " note : ");
                somme += float.Parse(Console.ReadLine());

                if (cpt == 6)
                {
                    moyenne = somme / cpt;
                    Console.Write("La moyenne est de : "+moyenne);
                }

            }
            Console.ReadKey();
            
        }
    }
}
