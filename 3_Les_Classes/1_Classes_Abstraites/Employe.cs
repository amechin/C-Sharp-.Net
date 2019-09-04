using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetTPClasse
{
    public abstract class Employe
        {
        public abstract string Matricule { get; set; }
        public abstract string Nom { get; set; }
        public abstract string Prenom { get; set; }
        public abstract DateTime DateNaissance{ get; set; }

        //Constructeur
        protected Employe(string matricule, string nom, string prenom, DateTime dateNaissance)
        {
            Matricule = matricule;
            Nom = nom;
            Prenom = prenom;
            DateNaissance = dateNaissance;
        }

        public override string ToString()
        {
            return "\n\nCategorie " + this.GetType().Name + "\n\n\tBonjour, je me présente je m'appelle " + Nom + " " + Prenom + "\n\tJe suis le matricule n°" + Matricule + "\n\tJe suis née le " + DateNaissance + "\n\tJe gagne un salaire de " + getSalaire() + " Euros";
        }

        public abstract int getSalaire();
       
    } 
}

