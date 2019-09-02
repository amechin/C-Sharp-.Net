using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulationChaine2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lecture de 5 mots separés par des espaces puis inversion de la phrase
            int nbMots = 0;
            string chaine = null;
            do
            {
                Console.WriteLine("Veuillez saisir une phrase comportant 5 mots");
                chaine = Console.ReadLine().ToString();
                
                //Comptage du nombre de mots
                nbMots = nbreDeMots(chaine);
                Console.WriteLine(nbMots);
            } while (nbMots != 5);

            //Les mots sont mis dans un tableau
            string[] mots = chaine.Split(' ');

            //Inversion des mots composants la phrase
            sautsLigne(2);
            Console.WriteLine("La phrase inversée est :");
            for(int i=mots.Length-1; i>=0; i--)
            {
                Console.Write(mots[i] + " ");
            }
            Console.ReadLine();
    }

        static int nbreDeMots(string chaine)
        {
            int compteur = 0;
            foreach (char c in chaine)
            {
                if (c.Equals(' '))
                {
                    compteur++;
                }
            }
            compteur++;
            return compteur;
        }

        static void sautsLigne(int nombre)
        {
            for(int i=0; i<nombre; i++)
            {
                Console.WriteLine();
            }
        }
    }
}
