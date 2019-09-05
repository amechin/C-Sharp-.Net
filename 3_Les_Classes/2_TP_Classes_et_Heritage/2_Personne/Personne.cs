using System;

namespace Personne
{
    class Personne
    {
        private string nom;
        private string prenom;
        private DateTime datenaissance;

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
        public DateTime Datenaissance
        {
            get { return datenaissance; }
            set { datenaissance = value; }
        }

        public Personne(string nom, string prenom, DateTime datenaissance)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Datenaissance = datenaissance;
        }

        public virtual void Afficher()
        {
            Console.Write("Nom: " + nom + " Prénom: " + prenom + " Date de naissance: " + datenaissance);
        }
    }
    //Source : www.exelib.net
}
