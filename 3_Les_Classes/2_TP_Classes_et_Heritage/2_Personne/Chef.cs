using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personne
{
    class Chef : Employe
    {
        private string service;

        public string Service
        {
            get { return service; }
            set { service = value; }
        }

        public Chef(string n, string p, DateTime dn, double s, string sv)
            : base(n, p, dn, s)
        {
            service = sv;
        }

        public override void Afficher()
        {
            base.Afficher();
            Console.Write(" Service: " + service);
        }
    }
}
