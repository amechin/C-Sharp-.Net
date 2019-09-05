using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TP_3Projets_5Septembre2019
{
    class Client
    {
        private string cin;
        private string nom;
        private string prenom;
        private string tel;

        public string Cin                  
        {
            get { return cin; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }

        public Client(string cin, string nom, string prenom, string tel)
        {
            this.cin = cin;
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
        }

        public Client(string cin, string nom, string prenom)
        {
            this.cin = cin;
            this.nom = nom;
            this.prenom = prenom;
        }

        public void Afficher()
        {
            Console.WriteLine("CIN: " + cin);
            Console.WriteLine("NOM: " + nom);
            Console.WriteLine("Prénom: " + prenom);
            if (tel != "")
                Console.WriteLine("Tél : " + tel);
        }
    }
}
