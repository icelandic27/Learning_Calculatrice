using Learning_Calculatrice;
bool boucle = true;
FileManagement.Load_Data();
while (boucle)
{
    Console.Clear();
    Menu.ShowInformations();
    string getInformations = Menu.GetInformations();

    if (getInformations.ToLower() == "q")
    {
        Environment.Exit(0);
    }
    else
    {
        FileManagement.Save_Data(Calcul.numeration++.ToString());
        Calcul Calculatrice = new Calcul();
        double calcul = Calculatrice.Calculatrice(getInformations);
        Calculatrice.ShowResultat(calcul);
        Console.WriteLine("Voulez vous refaire un calcul ?");
        string quitApp = Console.ReadLine();
        if (quitApp.ToLower() == "oui")
        {
            continue;
        }
        else
        {
            Environment.Exit(0);
        }
    }


}


