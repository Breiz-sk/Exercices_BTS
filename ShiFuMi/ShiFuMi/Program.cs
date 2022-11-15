using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiFuMi
{
    class Program
    {
        static void Main(string[] args)
        {
            Random nbreAlea = new Random();
            int nombreUtilisateur = 0, nombreOrdi=0;
            nombreOrdi = nbreAlea.Next(1, 4);// 4 pas compris, [1,4[
            Console.Write(nombreOrdi);
            
            do
            {
                Console.Write("Choisir un nombre : ");
                nombreUtilisateur = int.Parse(Console.ReadLine());

            } while (nombreUtilisateur != nombreOrdi);
            
            Console.WriteLine("WIN ! ");
            Console.ReadKey();
        }
    }
}
