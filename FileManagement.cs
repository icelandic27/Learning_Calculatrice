using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Calculatrice
{
    internal class FileManagement
    {
        public static string Data = "Data.txt";
        public static string Liste_Calcul = "Calcul.txt";

        public static void Save_Data(string data)
        {
            File.WriteAllText(Data, data);
        }
        public static void Load_Data()
        {
            if (File.Exists(Data))
            {
                Calcul.numeration = Int32.Parse(File.ReadAllText(Data));
            }
            else
            {
                Calcul.numeration = 1;
            }
        }
        public static void Save_Calcul(Dictionary<string, double> last_calcul)
        {

            foreach (var x in last_calcul)
            {
                File.AppendAllText(Liste_Calcul, $"{x.Key}{x.Value}" + Environment.NewLine);
            }

        }

        public static void Load_Calcul()
        {
            if (File.Exists(Liste_Calcul))
            {
               // foreach (Dictionary<string, double> in File.ReadLines(Liste_Calcul)) ;
            }
                

            
        }
    }
}
