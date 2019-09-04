using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetTPClasse
{
    class Patron : Employe
    {
        public int Taux { get; set; }
        public int CA { get; set; }
        public DateTime DateEntree { get; set; }
        public override string Matricule { get; set; }
        public override string Nom { get; set; }
        public override string Prenom { get; set; }
        public override DateTime DateNaissance { get; set; }

        //Constructeur
        public Patron(string matricule, string nom, string prenom, DateTime dateNaissance, int taux, int ca) : base(matricule, nom, prenom, dateNaissance)
        {
            Matricule = matricule;
            Nom = nom;
            Prenom = prenom;
            DateNaissance = dateNaissance;
            Taux = taux;
            CA = ca;
        }

        /**
         *  Un patron est un employé qui se caractérise par un chiffre d’affaire et un pourcentage.
         *  Le chiffre d’affaire est commun entre les patrons.
         *  Le patron a un salaire annuel qui est égal à x% du chiffre d'affaire : Salaire = CA*pourcentage/100 
         */
        public override int getSalaire()
        {
            return CA * Taux / 100;
        }

    }
}
