using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AppTabPosNeg 
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[20] {-4, 3, 7, 20, 1, -8, 12, -17, 14, -5, -7, 9, -13, 2, 18, -21, 6, 19, 4, -1};
            int[] tabPosi = new int[20] {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            int[] tabNega = new int[20] {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};

            int 
                cpt2 = 0,
                temp=0,
                cpt3 = 0;
            string 
                messagePositif="",
                messageNegatif="";

            for(int cpt=0;cpt<20;cpt++)
            {

                if (tab[cpt] >= 0 )
                {
                    tabPosi[cpt2] = tab[cpt];
                    cpt2++;
                }
                
                if (tab[cpt] < 0)
                {
                    tabNega[cpt3] = tab[cpt];
                    cpt3++;
                }
            }
            
            for (int cpt=0; cpt<cpt2; cpt++)
            {
                messagePositif += " "+tabPosi[cpt];
            }
                        
            for(int cpt=0; cpt<cpt3; cpt++)
            {
                messageNegatif += " "+tabNega[cpt];
            }

            Console.WriteLine("Tableau Positif : "+messagePositif);
            Console.WriteLine("Tableau Negatif : "+messageNegatif);

        }
    }
}