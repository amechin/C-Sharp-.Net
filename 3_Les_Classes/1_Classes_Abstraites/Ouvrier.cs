using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetTPClasse
{
   
    public class Ouvrier : Employe
    {
        const int smig = 2500;
        public DateTime DateEntree { get; set; }
        public override string Matricule { get; set; }
        public override string Nom { get; set; }
        public override string Prenom { get; set; }
        public override DateTime DateNaissance { get; set; }
        
        //Constructeur
        public Ouvrier(string matricule, string nom, string prenom, DateTime dateNaissance) : base(matricule, nom, prenom, dateNaissance)
        {
            Matricule = matricule;
            Nom = nom;
            Prenom = prenom;
            DateNaissance = dateNaissance;
        }

        /**
         * L’ouvrier a un salaire mensuel qui est : Salaire = SMIG + (Ancienneté en année)*100.
         * De plus, le salaire ne doit pas dépasser SMIG*2.
         */
        public override int getSalaire()
        {
            int anciennete = DateTime.Today.Year - DateEntree.Year;
            int salaire = smig + (anciennete * 100);

            if(salaire > smig * 2)
            {
                return smig * 2;
            }
            else
            {
                return salaire;
            }
        }

    }
}
