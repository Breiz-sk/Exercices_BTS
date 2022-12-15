using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPoint
{
    public class Point 
    {
        //variables
        private int colonne, ligne;

        private string couleur, caractere;

        // Constructeur 
        public Point(int uneColonne, int uneLigne, string unecouleur, string uncaractere)
        {
            this.colonne = uneColonne ;
            this.ligne = uneLigne;
            this.couleur = unecouleur ;
            this.caractere = uncaractere;
        }

        //Méthodes 

        public string afficher()
        {
            return "Colonne : "+colonne + "\nLigne : " + ligne + "\ncouleur : "+ couleur + "\ncaractère : "+caractere ; 
        }

        /*public string afficher(string cara, string coul)
        {

        }*/
        
        public void deplacer(int a, int b)
        {
            //string message ="" ; 
            //message += "Ancienne position  : \nLigne - "+ligne + "\nColonne - "+colonne ; 

            ligne = a ;
            colonne = b;

            //message += "\n\n Nouvelle position :\n\nLigne - "+ligne + "\nColonne - "+colonne ;

            //return message ; 

        }
    }


    // Programme et appel fonction
    class Programm
    {
        public static void Main(string[] args)
        {
            Point truc = new Point(2,3,"vert","c") ; 
            Point machin = new Point(4,8,"blouje","f") ;

            Console.WriteLine(machin.afficher());
            Console.WriteLine(machin.deplacer(5,9));
            Console.WriteLine(machin.afficher());

        }
    }


}

