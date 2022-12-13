using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnAsterix
{
    public class Personnage 
    {
        // Déclaration des types de la classe 
        private string 
            nom ,
            addresse ,
            fonction ,
            arme ; 
        
        private bool potion ; 

        private int 
            nbCombat ,
            force ,
            nbVictoire;

        // Constructeur 
        public Personnage(string unNom , string uneAddresse, string uneFonction, int unnbCombat, string uneArme, bool unePotion, int unForce, int uneNbVictoire)
        {
            this.nom = unNom ; 
            this.addresse = uneAddresse ;
            this.fonction = uneFonction ; 
            this.nbCombat = unnbCombat ; 
            this.arme = uneArme ;
            this.potion = unePotion ;
            this.force = unForce ; 
            this.nbVictoire = uneNbVictoire ; 
        }

        // Propriété
        public string Nom  
        {
            get { return nom;} 
            
            set { nom = value ;}
             
        }

        public string Addresse 
        {
            get { return addresse; } 
            
            set { addresse = value ;}
             
        }

        //Méthodes
        public void demenager( string nouvelleAdresse)
        {
            addresse = nouvelleAdresse ; 
        }

        public string seBattre()
        {
            if (puissance1 > puissance2 )
            {

            }
            nbCombat ++; 
            return "Le gagant du combat est : ";
        }

        public string puissance ()
        {
            if (potion == true ) 
            {
                force *=10 ; 
            }
            force +=10;
            return "La force de : "+ nom  +" après calcul, est de  "+ force ;
        }

        public  string afficher()
        {
           return nom + " " + addresse + " " + fonction + " " + nbCombat + " " + arme + " " + potion + " " + force + " " + nbVictoire ;
        }
    
        
    }

    public class Programm 
    {
        public static void Main(string[] args)
        {
            Personnage asterix = new Personnage("Astérix","Grande Rue","Guerrier",0,"Glaive",false,12,0);
            Personnage obelix = new Personnage("Obelix","Village Gaulois","Livreur menhir",0,"Poings",true,150,0);
            Personnage Romain = new Personnage("Antivirus","Rome","Soldat Romain",0,"Lance",false,9,0);

            
            /*
            Console.WriteLine(asterix.Addresse);
            asterix.Addresse = "Monde" ; 
            Console.WriteLine(asterix.Addresse);
            */
            asterix.demenager("Monde"); 
            Console.WriteLine(asterix.afficher()) ; 
            Console.WriteLine(asterix.puissance());
            
        }
    }
    
        
}
