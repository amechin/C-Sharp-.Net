using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierProjet
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tab = new int[3, 4] { { -1, 1, 100, 3 }, { 4, -50, 6, 7 }, { 8, 9, 5, 2 } };

            //Afichage du tableau 1 multidimmentionnel non ordonné
            Console.WriteLine("Tableau non ordonné");
            int i = 0;
            foreach (int item in tab)
            {
                if (i % 4 == 0)
                {
                    Console.WriteLine();
                }
                Console.Write(item);
                Console.Write("  ");
                i++;
            }


            //Recopie du tableau 1 multidimmentionnel dans un tableau 2 unidimmentionnel

            int taille = Convert.ToInt32(tab.Length);
            int[] tab2 = new int[taille];
            i = 0;
            foreach(int item in tab)
            {
                tab2[i] = item;
                i++;
            }
            

            //creation d'un tableau 3 dans lequel on stock les max du tableau 2
            int[] tab3 = new int[taille];
            while (taille>0)
            {
                for(int k=0; k<tab3.Length; k++)
                {
                    int valMax = tab2.Max();
                    int maxIndex = tab2.ToList().IndexOf(valMax);
                    tab3[k] = valMax;
                    tab2[maxIndex] = -1000000;
                    taille--;
                }  
            }

            //Afichage du tableau 3 unidimmentionnel ordonné de manière décroissante
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Tableau ordonné");
            foreach (int item in tab3)
            {
                if (i % 4 == 0)
                {
                    Console.WriteLine();
                }
                Console.Write(item);
                Console.Write("  ");
                i++;
            }
           
            Console.ReadLine();
        }
    }
}
