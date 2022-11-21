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
            //int 
            //    locationDiesel  = 70,
            //    locationEssence = 60,
            //    km = 0,
            //    duree = 0;
            
            double 
                //Const
                prixDiesel      = 0.20,
                prixEssence     = 0.25,
                locationDiesel  = 70,
                locationEssence = 60,
                
                //Variable
                calculDuree1    = 0,
                calculDuree2    = 0,
                CalculKm1       = 0,
                CalculKm2       = 0,
                km = 0,
                duree = 0;

            string 
                choix="";
            
            Console.Write("Durée de la location : ");
            duree = int.Parse(Console.ReadLine());
            
            Console.Write("Kilométrage : ");
            km = int.Parse(Console.ReadLine());
            
            calculDuree1 = duree * locationDiesel ;
            calculDuree2 = duree * locationEssence ;

            CalculKm1 = km * prixDiesel;
            CalculKm2 = km * prixEssence;

            calculDuree1 += CalculKm1;
            calculDuree2 += CalculKm2;

            if (calculDuree1 > calculDuree2)
            {
                Console.Write("Le prix d'une voiture Essence est plus interessant");
            }
            
            else if (calculDuree1 < calculDuree2) 
            {
                Console.Write("Le prix d'une voiture Diesel est plus interessant");
            }
            else 
            {
                Console.Write("Le prix d'une voiture Essence ou Diesel est le même");
            }
            
        }
    }
}