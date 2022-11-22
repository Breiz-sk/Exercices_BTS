using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMoyenneEleve
{
    class Program
    {
        static void Main(string[] args)
        {
            byte
                nbNotes;
            short
                somme=0;
            string
                prenom;
            float
                moyenne; 

            Console.Write("Saisie du nom de l'élève : ");
            prenom = Console.ReadLine();

            Console.Write("Saisie du nombre de note : ");
            nbNotes = byte.Parse(Console.ReadLine());

            for (byte cpt = 1; cpt <= nbNotes; cpt++)
            {
                Console.Write("Saisie de la note N°" + cpt+" : ");
                somme += byte.Parse(Console.ReadLine());
                
            }
            moyenne = somme / nbNotes;
            Console.Write("Moyenne de " + prenom+" : "+moyenne);
            Console.ReadKey();
        }
    }
}
