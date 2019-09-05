using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personne
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne[] tableauP = new Personne[8];
            //Des Affectations utilisant le concept du polymorphisme
            tableauP[0] = new Employe("Dupuis", "Jean", new DateTime(1995, 3, 1), 1700);
            tableauP[1] = new Employe("Mathieu", "Jacques", new DateTime(1994, 3, 1), 1500);
            tableauP[2] = new Employe("Frantz", "Véronique", new DateTime(1993, 3, 1), 2000);
            tableauP[3] = new Employe("Schmitt", "Simon", new DateTime(1992, 3, 1), 5000);
            tableauP[4] = new Employe("Ornet", "Lionel", new DateTime(1991, 3, 1), 4000);
            tableauP[5] = new Chef("Yamaka", "Marie", new DateTime(1998, 10, 1), 3000, "Marketing");
            tableauP[6] = new Chef("Fenet", "Guillaume", new DateTime(1994, 10, 1), 3000, "Marketing");
            tableauP[7] = new Directeur("Louri", "Emmanuelle", new DateTime(1989, 12, 25), 5000, "Direction", "Société XXX");

            Console.WriteLine("Affiche avec une boucle for");
            for (int i = 0; i < tableauP.Length; i++)
            {
                tableauP[i].Afficher();
                Console.WriteLine("");
            }

            Console.WriteLine("Affiche avec une boucle foreach");
            foreach (Personne p in tableauP)
            {
                p.Afficher();
                Console.WriteLine("");
            }

            Console.ReadKey();
        }
    }
}
