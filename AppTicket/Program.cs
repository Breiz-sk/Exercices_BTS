using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            double[]  tabPrix =  new double[10]  ; 
            int[]   tabQt =    new int[10] ;
            string[] tabNoms =  new string[10] ;
            
            int 
                nbreArticle=0;

            double 
                somme=0 ,
                sommeTotale=0,
                prixTTC=0,
                tva=0;

            // COMMANDE

            while (nbreArticle < 10)
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine("\nARTICLE "+(nbreArticle+1)+"\n");
                Console.Write("Nom de l'article : ");
                tabNoms[nbreArticle] = Console.ReadLine();

                if (tabNoms[nbreArticle]=="0")
                {
                    break;
                }
                Console.Write("Prix de l'article : ");
                tabPrix[nbreArticle] = double.Parse(Console.ReadLine());

                Console.Write("Quantité de l'article : ");
                tabQt[nbreArticle] = int.Parse(Console.ReadLine());
                
                nbreArticle++;
                
            }

            // TICKET 
            Console.WriteLine("\nTICKET\n-------------------------------");

            for (byte cpt=0;cpt<nbreArticle; cpt++)
            {
                somme = ((tabPrix[cpt]) * (tabQt[cpt]));
                sommeTotale += somme ;
                Console.WriteLine(tabNoms[cpt]+"\t"+tabPrix[cpt]+" Euros\t"+tabQt[cpt]+" fois");
            }

            
            tva = sommeTotale *0.055;
            prixTTC = tva+sommeTotale;
            Console.WriteLine("\nPrix TTC : "+prixTTC);
            Console.WriteLine("TVA : "+tva);
        }

    }
}