using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTabRecherches
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[10] { 12,5,3,33,4,52,22,1,6,25 };
            
            int   
                petit=100,
                valeur=33,
                max = 0,
                cpt = 0,
                position_valeur=0,
                position_min=0,
                position_max=0;

            while (cpt < 10 )
            {
                if (tab[cpt] > 20 )
                {
                    Console.WriteLine(tab[cpt]+" est > à 20");
                }

                if (tab[cpt] < petit  )
                {
                    petit = tab[cpt];
                }
                
                if (tab[cpt] > max  )
                {
                    max = tab[cpt];
                }
                
                cpt++;
            }
            
            for(cpt=0;cpt<10;cpt++)
            {
                if (petit == tab[cpt]){
                    position_min = cpt ; 
                    break;
                }
            }
            
            for(cpt=0;cpt<10;cpt++)
            {
                if (max == tab[cpt]){
                    position_max = cpt ; 
                    break;
                }
            }
            for(cpt=0;cpt<10;cpt++)
            {
                if (valeur == tab[cpt]){
                    position_valeur = cpt ; 
                    break;
                }
            }            
            
            Console.WriteLine("La plus petite valeur est : "+petit+" à la position : "+position_min);
            Console.WriteLine("La plus grande valeur est : "+max+" à la position : "+position_max);
            Console.WriteLine("La valeur : "+valeur+" est à la position : "+position_valeur);


            Console.ReadKey();
        }
    }
}
