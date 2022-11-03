using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Calculatrice
{
    internal class Menu
    {
        private static string choix;
        public static string Choix
        {
            get { return choix; }
            set { choix = value; }
        }

        //public List<string> Selection { get; set; }

        public static void ShowInformations()
        {
            //String readText = File.ReadAllText("Data.txt");

            List<string> selection = new List<string> { "Addition", "Soustraction", "Multiplication", "Divison",
                "Ln", "Log nombre + base", "X puissance Y" };
            int index = 1;
            Console.WriteLine("Calculateur Console 2 nombres");
            Console.WriteLine($"Le Calculateur à été utilisé : {Calcul.numeration} Fois\n");
            
            foreach (var x in selection)
            {
                Console.WriteLine($"Option {index++} : {x}");
            }
            Console.WriteLine("Q pour Quitter\n");
            Console.Write("Votre choix : ");

        }
        public static string GetInformations()
        {
            Choix = Console.ReadLine();
            return Choix;
        }

        






    }
}
