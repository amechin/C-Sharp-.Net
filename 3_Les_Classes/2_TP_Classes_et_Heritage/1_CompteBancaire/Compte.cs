using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_3Projets_5Septembre2019
{
    class Compte
    {
        private int numero;
        private double solde;
        private Client proprietaire;
        private static int nombre_comptes = 0;

        public int Numero                                              
        {
            get { return numero; }
        }

        public double Solde                           
        {
            get { return solde; }
        }

        public Client Proprietaire
        {
            get { return proprietaire; }
            set { proprietaire = value; }
        }

        public Compte(Client proprietaire)
        {
            nombre_comptes++;
            numero = nombre_comptes;
            this.proprietaire = proprietaire;
        }

        public void Crediter(double somme)
        {
            solde += somme;
            Console.WriteLine("Opération bien effectuée");
        }

        public void Crediter(Compte c, double somme)                   
        {
            if (c.solde >= somme)
            {
                c.solde -= somme;
                solde += somme;
                Console.WriteLine("Opération bien effectuée");
            }
            else
                Console.WriteLine("Solde de compte insuffisant");
        }

        public void Debiter(double somme)
        {
            if (solde >= somme)
            {
                solde -= somme;
                Console.WriteLine("Opération bien effectuée");
            }
            else
                Console.WriteLine("Solde insuffisant");
        }

        public void Debiter(Compte c, double somme)              
        {
            if (solde >= somme)
            {
                solde -= somme;
                c.solde += somme;
                Console.WriteLine("Opération bien effectuée");
            }
            else
                Console.WriteLine("Solde insuffisant");
        }

        public void Afficher()
        {
            Console.WriteLine("************************");
            Console.WriteLine("Numéro de Compte: " + numero);
            Console.WriteLine("Solde de compte: " + solde);
            Console.WriteLine("Propriétaire du compte : ");
            proprietaire.Afficher();
            Console.WriteLine("*************************");
        }

        public static void Nombre_Comptes()
        {
            Console.WriteLine("\n\nLe nombre de comptes crées: " + nombre_comptes);
        }
    }
}
