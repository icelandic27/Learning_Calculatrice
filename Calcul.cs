using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Calculatrice
{
    internal class Calcul
    {
        private double nombre_1;
        private double nombre_2;
        private double valeur;

        public double Nombre1
        {
            get { return nombre_1; }
            set { nombre_1 = value; }
        }
        public double Nombre2
        {
            get { return nombre_2; }
            set { nombre_2 = value; }

        }
        public double Valeur
        {
            get { return valeur; }
            set { valeur = value; }
        }

        public double Calculatrice(int choix)
        {

            Console.Write("Votre premier nombre :");

            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Votre deuxième nombre :");

            double y = Convert.ToDouble(Console.ReadLine());

            switch (choix)
            {
                case 0:
                    {
                        Valeur = x + y;
                        break;
                    }
                case 2:
                    {
                        Valeur = x - y;
                        return Valeur;
                    }
                case 3:
                    {
                        Valeur = x * y;
                        return Valeur;
                    }
                case 4:
                    {
                        Valeur = x / y;
                        return Valeur;
                    }
            }
            return 0;
        }


    }
}

