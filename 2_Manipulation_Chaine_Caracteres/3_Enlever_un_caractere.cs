using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnleverLesA
{
    class Program
    {
        static void Main(string[] args)
        {
            string chaine = null, temp = null;
            int taille = 0;
            do
            {
                Console.WriteLine("Saisir une phrase (100 caractères maximum)");
                chaine = Console.ReadLine().ToString();
                taille = chaine.Length;
            }
            while (taille > 100);

            foreach (char c in chaine)
            {
                if(c != 'a' && c != 'A')
                {
                    temp += c.ToString();
                }
            }

            
            Console.WriteLine("La phrase sans le 'A' est : \n\t -> " + temp);
            Console.ReadLine();
        }
    }
}
