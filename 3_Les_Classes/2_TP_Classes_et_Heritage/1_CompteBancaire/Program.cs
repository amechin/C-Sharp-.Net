using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_3Projets_5Septembre2019
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Compte 1: ");
            string cin, nom, prenom, tel;
            Console.Write("Donner Le CIN: ");
            cin = Console.ReadLine();
            Console.Write("Donner Le Nom: ");
            nom = Console.ReadLine();
            Console.Write("Donner Le Prénom: ");
            prenom = Console.ReadLine();
            Console.Write("Donner Le numéro de télephone: ");
            tel = Console.ReadLine();

            Compte C1 = new Compte(new Client(cin, nom, prenom, tel));
            Console.WriteLine("Détails du compte: ");
            C1.Afficher();

            double montant;
            Console.WriteLine("Donner le montant à déposer: ");
            montant = double.Parse(Console.ReadLine());
            C1.Crediter(montant);
            C1.Afficher();

            Console.WriteLine("Donner le montant à retirer: ");
            montant = double.Parse(Console.ReadLine());
            C1.Debiter(montant);
            C1.Afficher();

            Console.WriteLine("\n\nCompte 2: ");
            Console.Write("Donner Le CIN: ");
            cin = Console.ReadLine();
            Console.Write("Donner Le Nom: ");
            nom = Console.ReadLine();
            Console.Write("Donner Le Prénom: ");
            prenom = Console.ReadLine();
            Console.Write("Donner Le numéro de télephone: ");
            tel = Console.ReadLine();

            Compte C2 = new Compte(new Client(cin, nom, prenom, tel));
            Console.WriteLine("Détails du compte: ");
            C2.Afficher();

            Console.WriteLine("Crediter le compte 2 à partir du compte 1");
            Console.Write("Donner le montant à déposer: ");
            montant = double.Parse(Console.ReadLine());
            C2.Crediter(C1, montant);

            Console.WriteLine("Débiter le compte 1 et créditer le compte 2");
            Console.Write("Donner le montant à retirer: ");
            montant = double.Parse(Console.ReadLine());
            C1.Debiter(C2, montant);

            C1.Afficher();
            C2.Afficher();

            Compte.Nombre_Comptes();

            Console.ReadLine();
        }
    }
}
