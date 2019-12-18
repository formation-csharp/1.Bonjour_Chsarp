using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonjour_Chsarp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Saisie de votre Nom : 
            string Nom;
            Console.Write("Donnez votre Nom :");
            Nom = Console.ReadLine();

            Console.WriteLine("Votre Nom :" + Nom);


            // Pour arrêter la fermeture du console.
            Console.ReadKey();
        }
    }
}
