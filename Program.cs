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
            int unumber;
            int i;
            Random aleatoire;

            i = 1;
            aleatoire = new Random();
            number = aleatoire.Next(1, 51);
            unumber = 0;
            while (number != unumber)
            {
                Console.WriteLine("Devinez le nombre mystère, il est compris entre 1 et 50");
                unumber = int.Parse(Console.ReadLine());
                if (number > unumber && unumber > 0)
                    Console.WriteLine("le nombre mystère est plus haut rééssayez");           
                else if (number < unumber && unumber < 51)
                    Console.WriteLine("le nombre mystère est plus bas");
                i++;
            }
            Console.WriteLine("Bravo, vous avez trouvé ! et cela en seulement " + i + " tentatives");

        }
    }
}
