using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetTPClasse
{
    class Cadre : Employe
    {
        public int Indice { get; set; }
        public DateTime DateEntree { get; set; }
        public override string Matricule { get; set; }
        public override string Nom { get; set; }
        public override string Prenom { get; set; }
        public override DateTime DateNaissance { get; set; }

        //Constructeur
        public Cadre(string matricule, string nom, string prenom, DateTime dateNaissance, int indice) : base(matricule, nom, prenom, dateNaissance)
        {
            Matricule = matricule;
            Nom = nom;
            Prenom = prenom;
            DateNaissance = dateNaissance;
            Indice = indice;
        }

        /**
         * Le cadre a un salaire qui dépend de son indice :
         *  1 : salaire mensuel 13000 DH
         *  2 : salaire mensuel 15000 DH
         *  3 : salaire mensuel 17000 DH
         *  4 : salaire mensuel 20000 DH
         */
        public override int getSalaire()
        {
            switch (Indice)
            {
                case 1:
                    return 13000;
                case 2:
                    return 15000;
                case 3:
                    return 17000;
                case 4:
                    return 20000;
                default:
                    return 0;
            }
        }
    }
}
