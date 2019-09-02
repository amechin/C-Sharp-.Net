using System;

namespace ChaineDeCaractere
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saisissez une phrase");
            string chaine = Console.ReadLine();

            testerPremiereLettre(chaine);

            testerSeFiniParUnPoint(chaine);

            nbreDeMots(chaine);

            Console.WriteLine("La phrase contient " + nbreDeCaracteres(chaine) + " caractère(s)");

            nbredEspaces(chaine);

            Console.ReadLine();
        }

        static void testerPremiereLettre(string chaine)
        {
            string c1 = chaine[0].ToString();
            if (c1.Equals(c1.ToUpper()))
            {
                Console.WriteLine("La première lettre est en majuscule");
            }
            else
            {
                Console.WriteLine("La première lettre est en minuscule");
            }
        }

        static void testerSeFiniParUnPoint(string chaine)
        {
            string c = chaine[chaine.Length - 1].ToString();
            if (c.Equals("."))
            {
                Console.WriteLine("Le dernier caractère est un point");
            }
            else
            {
                Console.WriteLine("Le dernier caractère n'est pas un point");
            }
        }

        static void nbreDeMots(string chaine)
        {
            int compteurEspaces = 0;
            foreach(char c in chaine)
            {
                if (c.Equals(' '))
                {
                    compteurEspaces++;
                }
            }
            compteurEspaces += 1;
            Console.WriteLine("Il y a "+ compteurEspaces +" mot(s) dans cette phrase");
        }

        static int nbreDeCaracteres(string chaine)
        {
            return chaine.Length;
        }

        static void nbredEspaces(string chaine)
        {
            int compteurEspaces = 0;
            foreach (char c in chaine)
            {
                if (c.Equals(' '))
                {
                    compteurEspaces++;
                }
            }
            Console.WriteLine("Il y a " + compteurEspaces + " espace(s) dans cette phrase");
        }
    }
}
