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

        

        //public List<string> Selection { get; set; }


        public static int ShowInformations()
        {
            List<string> selection = new List<string> { "Addition", "Multiplication", "Division", "Soustraction" };
            int index = 1;
            Console.WriteLine("Calculateur Console");
            foreach (var x in selection)
            {
                Console.WriteLine($"\tOption {index++} : {x}");
            }
            Console.Write("Votre choix : ");
            int choix = Convert.ToInt32(Console.ReadLine());
            return choix;
        }






    }
}
