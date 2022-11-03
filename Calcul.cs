using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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
        private bool boucle = true;
        public static int numeration;
        private static string type;
        public Dictionary<string, double> Data;

        public static string Type
        {
            get { return type; }
            set { type = value; }  
        }

        public bool Boucle
        {
            get { return boucle; }
            set { boucle = value; }
        }
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

        public double Calculatrice(string choix)
        {

            Console.Write("Votre premier nombre : ");

            Nombre1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Votre deuxième nombre : ");

            Nombre2 = Convert.ToDouble(Console.ReadLine());

            switch (choix)
            {
                case "1":
                    {

                        Valeur = Addition(Nombre1, Nombre2);
                        Type = "+";
                        break;
                    }
                case "2":
                    {
                        Valeur = Soustraction(Nombre1, Nombre2);
                        Type = "-";
                        break;
                    }
                case "3":
                    {
                        Valeur = Multiplication(Nombre1, Nombre2);
                        Type = "*";
                        break;
                    }
                case "4":
                    {
                        Valeur = Divison(Nombre1, Nombre2);
                        Type = "/";
                        break;
                    }
                case "5":
                    {
                        Valeur = Ln(Nombre1);
                        break;
                    }
                case "6":
                    {
                        Valeur = Log(Nombre1, Nombre2);
                        break;
                    }
                case "7":
                    {
                        Valeur = Power(Nombre1, Nombre2);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Erreur");
                        break;
                    }

            }
            return Valeur;
        }

        public static double Addition(double arg1, double arg2)
        {
            return arg1 + arg2;
        }
        public static double Soustraction(double arg1, double arg2)
        {
            return arg1 - arg2;
        }
        public static double Multiplication(double arg1, double arg2)
        {
            return arg1 * arg2;
        }
        public static double Divison(double arg1, double arg2)
        {
            return arg1 / arg2;
        }
        public static double Ln(double arg1)
        {
            return Math.Log(arg1);
        }
        public static double Log(double arg1, double arg2)
        {
            return Math.Log(arg1, arg2);
        }
        public static double Power(double arg1, double arg2)
        {
            return Math.Pow(arg1, arg2);
        }
        public void ShowResultat(double input)
        {

            Console.WriteLine($"Le résultat de {Nombre1} {Type} {Nombre2} est {input}\n");
            String x = $"{Nombre1.ToString()} {Type.ToString()} {Nombre2.ToString()} = ";
            Dictionary <string, double> result = new Dictionary<string, double>();
            result.Add(x, input);
            FileManagement.Save_Calcul(result);
            

        }
    }
}

