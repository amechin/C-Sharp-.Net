using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personne
{
    class Directeur : Chef
    {
        private string societe;

        public string Societe
        {
            get { return societe; }
            set { societe = value; }
        }

        public Directeur(string n, string p, DateTime dn, double s, string ser, string ste) : base(n, p, dn, s, ser)
        {
            societe = ste;
        }

        public override void Afficher()
        {
            base.Afficher();
            Console.Write(" Société: " + societe);
        }
    }
}
