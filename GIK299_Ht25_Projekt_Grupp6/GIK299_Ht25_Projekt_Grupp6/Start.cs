namespace GruppXproject
{
    internal class Start
    {
        internal static void start()
        {
            //Logga in på adminpanelen
            while (true)
            {
                Console.WriteLine("---Adminpanel---");
                Console.Write("Lösenord: ");
                string AdminPassword = Console.ReadLine();

                //Om lösenordet är rätt starta programmet
                if (AdminPassword == "admin123")
                {
                    while (true)
                    {
                        //Menyn är anropas från en annan fil för bättre läsbarhet
                        Menu.StartMenu();
                    }
                }
                else
                {
                    Console.WriteLine("FEL lösenord");
                }
            }
        }
    }
}
