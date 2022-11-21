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
            int 
                locationDiesel  = 70,
                locationEssence = 60,
                prixDiesel  = 0.20,
                prixEssence = 0.25, 
                km = 0,
                duree = 0,
                calculDuree1 = 0,
                calculDuree2 = 0,
                CalculKm1 = 0,
                CalculKm2 = 0;

            string 
                choix="";
            
            Console.Write("Durée de la location : ");
            //duree = int.Parse(Console.ReadLine());
            choix = Console.ReadLine();
            duree = int.Parse(choix);
            
            Console.Write("Kilométrage : ");
            //km = int.Parse(Console.ReadLine());
            choix = Console.ReadLine();
            km = int.Parse(choix);

            Console.WriteLine("Km : "+km+" | Duree : "+duree);
            
            calculDuree1 = duree * locationDiesel ;
            calculDuree2 = duree * locationEssence ;

            CalculKm1 = km * prixDiesel;
            CalculKm2 = km * prixEssence;

            calculDuree1 += CalculKm1;
            calculDuree2 += CalculKm2;

            Console.WriteLine("Diesel : "+calculDuree1+" | Essence"+calculDuree2);
        }
    }
}