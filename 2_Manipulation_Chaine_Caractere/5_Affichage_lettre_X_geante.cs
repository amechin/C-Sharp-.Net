using System;

namespace AfficherX
{
    class Program
    {
        static void Main(string[] args)
        {
            int gauche = 0, droite;
            int tempG, tempD;
            int l, ep;

            /**
            * On efface l'écran et on pose deux questions à l'utilisateur pour définir la taille de la lettre affichée
            */
            Console.Clear();
            Console.WriteLine("Quelle largeur de lettre souhaitez-vous ? (entre 10 et 50)");
            l = (int.Parse(Console.ReadLine()));

            Console.Clear();
            Console.WriteLine("Quelle épaisseur de lettre souhaitez-vous ? (entre 1 et 25)");
            ep = (int.Parse(Console.ReadLine()));

            /*
            * on va manipuler la variable droite donc on lui assigne la largeur saisie par l'utilisateur
            */
            droite = l;

            /*
            * On efface l'écran et on rentre dans les boucles pour affichage ligne a ligne de la lettre
            */
            Console.Clear();

            for (int y = 0; y < l; y++)
            {
                /*
                * On met dans des variables temporaires les variables droite et gauche
                */
                tempD = droite;
                tempG = gauche;
                for (int i = 0; i < ep; i++)
                {
                    Console.SetCursorPosition(tempG, y);
                    Console.Write("X");
                    tempG += 1;

                    Console.SetCursorPosition(tempD, y);
                    Console.Write("X");
                    tempD += 1;
                }
                gauche += 1;
                droite -= 1;
            }
            Console.ReadLine();
        }
    }
    
}
