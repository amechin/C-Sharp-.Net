using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saisissez un mot, une phrase, je vous dirai s'il s'agit d'un palindrome");
            string chaine = Console.ReadLine().ToString();

            int nbCar = chaine.Length;
            int reste = nbCar % 2;

            if (reste.Equals(0))
            {
                //nombre de lettres pair : on extrait deux ss chaines de caractere, on inverse la deuxieme et on les compare
                string ssChaine1 = chaine.Substring(0, nbCar / 2);
                string ssChaine2 = chaine.Substring(nbCar / 2, nbCar / 2);

                if (ssChaine1.CompareTo(Reverse(ssChaine2))==0)
                {
                    Console.WriteLine(chaine + " est bien un palindrome");
                }
                else
                {
                    Console.WriteLine(chaine + " n'est pas un palindrome");
                }
            }
            else
            {
                // Gestion du cas ou l'utilisateur saisie une lettre
                if(nbCar == 1)
                {
                    Console.WriteLine("Un palindrome doit être un mot de deux lettres minimum");
                }
                //nombre de lettres impair : on extrait deux ss chaines de caractere, on inverse la deuxieme et on les compare 
                else
                {
                    string ssChaine1 = chaine.Substring(0, nbCar / 2);
                    string ssChaine2 = chaine.Substring(nbCar / 2 + 1, nbCar / 2);

                    if (ssChaine1.CompareTo(Reverse(ssChaine2)) == 0)
                    {
                        Console.WriteLine(chaine + " est bien un palindrome");
                    }
                    else
                    {
                        Console.WriteLine(chaine + " n'est pas un palindrome");
                    }
                }
            }
            Console.ReadLine();

            // fonction pour inverser une chaine de caractère
            string Reverse(string texte)
            {
                char[] caracteres = texte.ToCharArray();
                Array.Reverse(caracteres);
                return new String(caracteres);
            }
        }
       
    }
}
