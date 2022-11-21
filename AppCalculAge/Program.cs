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
                jourNaissance,
                moisNaissance,
                calculAnnee ,
                age=0,
                calculMois,
                calculJour,
                anneeNaissance; 
            
            string 
                prenom="";
            
            
            DateTime uneDate = DateTime.Now;
            int jourDate  = uneDate.Day;
            int moisDate  = uneDate.Month;
            int anneeDate = uneDate.Year;
            
            Console.Write("Donnez votre prénom : ");
            prenom = Console.ReadLine();
            
            Console.Write("Donnez votre jour de naissance JJ : ");
            jourNaissance = byte.Parse(Console.ReadLine());
           
           Console.Write("Donnez votre mois de naissance MM : ");
            moisNaissance =  byte.Parse(Console.ReadLine());
            
            Console.Write("Donnez votre année de naissance AAAA : ");
            anneeNaissance =  short.Parse(Console.ReadLine());

            calculAnnee = anneeDate - anneeNaissance;
            calculMois = moisDate - moisNaissance;
            calculJour = jourDate - jourNaissance;


            if (calculJour > 0 && calculMois > 0 ) {
                age ++;
            }
            age += calculAnnee;

        
            Console.WriteLine("Date d'aujourd'hui : "+jourDate+ "/"+ moisDate+ "/"+ anneeDate);

            Console.Write("Bonjour "+prenom+", Vous avez "+age+" ans.");
            
        }
    }
}