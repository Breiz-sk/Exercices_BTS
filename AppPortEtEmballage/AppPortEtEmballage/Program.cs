using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPortEtEmballage
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal port ; //Nik
            short prix,emballage = 0, horsTaxe ;
            string Str;
            
            
            Console.WriteLine("Montant HT : ");
            Str = Console.ReadLine();
            horsTaxe = short.Parse(Str);

            if (horsTaxe < 800)
            {
                if (horsTaxe < 80)
                {
                    emballage = 15;
                }
                else if (horsTaxe <= 600 && horsTaxe > 80)
                {
                    emballage = 45;
                }
                else
                {
                    emballage = 75;
                }
                
                port = horsTaxe*0.05M;
                Console.WriteLine("Port : "+port);
                Console.WriteLine("Emballage : " + emballage);
            }
            
            else
            {
                port = horsTaxe * 0.03M;
                emballage = 75;
                Console.WriteLine("Port : "+ port);
                Console.WriteLine("Emballage : " + emballage);
            }

            Console.ReadKey();

        }
    }
}
