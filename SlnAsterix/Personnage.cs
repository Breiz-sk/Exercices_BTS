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

        public string Fonction 
        {
            get { return fonction; } 
            
            set { fonction = value ;}
             
        }

        public int NbCombat 
        {
            get { return nbCombat; } 
            
            set { nbCombat = value ;}
             
        }

        public string Arme 
        {
            get { return arme; } 
            
            set { arme = value ;}
             
        }

        public bool Potion 
        {
            get { return potion; } 
            
            set { potion = value ;}
             
        }

        public int Force 
        {
            get { return force; } 
            
            set { force = value ;}
             
        }

        public int NbVictoire 
        {
            get { return nbVictoire; } 
            
            set { nbVictoire = value ;}
             
        }

        //Méthodes
        public void demenager( string nouvelleAdresse)
        {
            addresse = nouvelleAdresse ; 
        }

        public string seBattre()
        {
            nbCombat ++;
            if (force > 150 )
            {
                nbVictoire++;
                return "Le gagant du combat est :  " +nom;
            }

            else if (force < 150) 
            {
                return "Le gagant du combat n'est pas " +nom;
            }
            else 
            {
                return "Egalité";
            }
            
            
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

            
            asterix.demenager("Monde"); 

            Console.WriteLine(asterix.afficher()); 
            Console.WriteLine(asterix.puissance());

            Console.WriteLine(asterix.seBattre()); 
            Console.WriteLine(asterix.afficher()); 

            
        }
    }
    
        
}
