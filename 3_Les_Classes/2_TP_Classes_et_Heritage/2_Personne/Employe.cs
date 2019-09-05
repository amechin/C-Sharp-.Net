using System;

namespace Personne
{
    class Employe : Personne
    {
        private double salaire;

        public double Salaire
        {
            get { return salaire; }
            set { salaire = value; }
        }

        public Employe(string n, string p, DateTime dn, double s) : base(n, p, dn)
        {
            salaire = s;
        }

        public override void Afficher()
        {
            base.Afficher();
            Console.Write(" Salaire: " + salaire);
        }
    }
}
