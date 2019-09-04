using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetTPClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creation d'un ouvrier
            Ouvrier ouv1 = new Ouvrier("0001", "Dupont", "Albert", DateTime.Parse("24/10/1990"));
            Console.WriteLine(ouv1);

            Cadre cad1 = new Cadre("0002", "Martin", "Steven", DateTime.Parse("30/10/1986"), 2);
            Console.WriteLine(cad1);

            Patron patron = new Patron("0003", "Bonnefoy", "Damien", DateTime.Parse("28/10/1957"), 20, 100000);
            Console.WriteLine(patron);
            Console.ReadLine();
        }
    }
}
