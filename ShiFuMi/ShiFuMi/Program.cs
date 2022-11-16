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
            int
                nombreUtilisateur = 0,
                nombreOrdi = 0,
                cptManche = 0,
                cptOrdi = 0,
                cptJoueur = 0;
            string
                resultat = "",
                choix = "",
                choix2 = "";
            bool
                stop = false;

            do
            {
                nombreOrdi = nbreAlea.Next(1, 4);// 4 pas compris, [1,4[
                Console.Write("-------------------------------------------\n" +
                              "SHIFUMI\n1 - Pierre\n2 - Feuille\n3 - Ciseau \n0 - Quitter\nChoisir : ");
                nombreUtilisateur = int.Parse(Console.ReadLine());
                
                if (nombreUtilisateur == 0) // Si l'utilisateur rentre le 0 
                {
                    stop = true; // permet d'arrêter le while
                    break;           

                }

                switch (nombreUtilisateur) // Représenter par un string le choix utilisateur
                {
                    case 1:
                        choix2 = "Pierre";
                        break;
                    case 2:
                        choix2 = "Feuille";
                        break;
                    case 3:
                        choix2 = "Ciseau";
                        break;
                }

                switch (nombreOrdi)// Représenter par un string le choix ordinateur
                {
                    case 1:
                        choix = "Pierre";
                        break;
                    case 2:
                        choix = "Feuille";
                        break;
                    case 3:
                        choix = "Ciseau";
                        break;
                }

                if (nombreOrdi == nombreUtilisateur)
                {
                    resultat = "Egalité";
                }
                else if ( (nombreUtilisateur==1 && nombreOrdi==2) || (nombreUtilisateur==2 && nombreOrdi==3) || (nombreUtilisateur==3 && nombreOrdi==1) )
                {
                    resultat = "Perdu";
                    cptOrdi++;
                }
                else
                {
                    resultat = "Gagné";
                    cptJoueur++;
                }
                cptManche++;
                Console.WriteLine("\nVous : " + choix2 + " \nOrdinateur : " + choix+"\n"+resultat+"\n");
                Console.WriteLine("Manche "+ cptManche + "\nJoueur : "+cptJoueur+"\nOrdinateur : "+cptOrdi);

            } while ( stop != true && cptManche !=10 && (cptJoueur < 5 && cptOrdi < 5)) ; 
            // tant que stop pas vrai et cpt manque pas égale à 10 et que cptJoueur inférieur à 5 et cptOrdi inférieur à 5
            
            
            
            Console.WriteLine("\nFin du Programme ");
            Console.ReadKey();
        }
    }
}
