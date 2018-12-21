using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parti1_tp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* choisir un nombre 
             * demander à l'utilisateur de rentrer un nombre
             * comparer unumber avec number
             * Donner des instructions à user */
            int number;
            int userNumber;
            int counter;
            Random aleatoire;

            counter = 1;
            aleatoire = new Random();
            number = aleatoire.Next(1, 51);
            userNumber = 0;
            Console.SetCursorPosition(10, 1); //permet de positionner la position (x,y)
            Console.BackgroundColor = ConsoleColor.Magenta;//permet de mettre une position en background
            Console.ForegroundColor = ConsoleColor.Black;// permet de mettre une couleur de text
            Console.WriteLine("Devinez le nombre mystère, il est compris entre 1 et 50");//affiche la phrase entre double quote
            while (number != userNumber)
            {
                userNumber = int.Parse(Console.ReadLine());
                if (number > userNumber && userNumber > 0)
                {
                    Console.Clear();// Efface tout ce qui a été inscrit avant
                    Console.WriteLine("Devinez le nombre mystère, il est compris entre 1 et 50");
                    Console.WriteLine("le nombre mystère est plus haut réessayez");
                }
                else if (number < userNumber && userNumber < 51)
                {
                    Console.Clear();
                    Console.WriteLine("Devinez le nombre mystère, il est compris entre 1 et 50");
                    Console.WriteLine("le nombre mystère est plus bas");
                }
                counter++;
            }
            Console.WriteLine("Bravo, vous avez trouvé ! et cela en seulement " + counter + " tentatives");

        }
    }
}
