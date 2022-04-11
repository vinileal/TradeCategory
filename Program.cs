using System;
using System.Globalization;
using TradeCategory;
using TradeCategory.Implements;

class Promgram
{
    static void Main()
    {
        List<Category> list = new List<Category>();
        ImplCategory a = new ImplCategory();
        list = a.DefaultCategories();

        string[] arrayOption = { "1 - Question one (Classify Trades) ", "2 - Question two (PEP and Classify Trades)" };
        int selectedOption = 0;

        Console.WriteLine("Welcome to Trade Business Categorization");

        MenuOption();

        if (selectedOption == 1)
            CategorifyTradesMenu();
        else if (selectedOption == 2)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Create a 'PoliticallyExposedPerson' method that returns a 'bool' in the class that implements an interface ITrade, however, depend to the characteristics of this classification, it is necessary to create another class implementing the ITrade interface.");
            Console.ResetColor();
        }
        else
            MenuOption();


        #region Menu Options
        void MenuOption()
        {
            Console.WriteLine("\r\nPlease select a value between 1 and " + arrayOption.Length);

            //print list of options
            for (int i = 0; i < arrayOption.Length; i++)
                Console.WriteLine(arrayOption[i] + ";");

            Console.Write("\r\nOption: ");

            //if the value is different from the number it returns to the options menu
            if (!int.TryParse(Console.ReadLine(), out selectedOption))
            {
                Console.WriteLine("\r\nInvalid Input.");
                MenuOption();
            }
        }
        #endregion

        #region Categorify Trades Menu
        void CategorifyTradesMenu()
        {
            DateTime referenceDate = new DateTime();
            int numberOfTrades = 0;
            CultureInfo idioma = new CultureInfo("pt-BR");

            Console.WriteLine("Please select the 'Reference Date' and the 'Number of Trades' for this customer :\r\n");

            //test invalid inputs
            Console.Write("Date (Ex.: '31/12/2022') :");
            while (!DateTime.TryParse(Console.ReadLine(), idioma, DateTimeStyles.None, out referenceDate))
            {
                Console.WriteLine("\r\nInvalid Date Format.");
                Console.Write("\r\nDate (Ex.: '31/12/2022') :");
            }

            Console.Write("Number of Trades (Ex.: '12') :");
            while (!int.TryParse(Console.ReadLine(), out numberOfTrades))
            {
                Console.WriteLine("\r\nInvalid Number.");
                Console.Write("Number of Trades (Ex.: '12') :");
            }

            Console.WriteLine("Please insert the 'Value of Transaction', 'Client Sector (Private or Public)' and the 'Next Payment Date'.");
            Console.WriteLine("Ex.: '2000000 Private 31/12/2025' :\r\n");

            ImplTradeCategorify trade = new ImplTradeCategorify();
            List<String> categories = new List<String>();
            string[] line;

            for (int i = 0; i < numberOfTrades; i++)
            {
                try
                {
                    Console.Write("Trade " + (i + 1) + " :");

                    line = Console.ReadLine().Split(" ");
                    trade.Value = double.Parse(line[0].ToString());
                    trade.ClientSector = line[1].ToUpper();
                    trade.NextPaymentDate = DateTime.Parse(line[2].ToString());
                    categories.Add(trade.TradeCategorify(referenceDate, trade));
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Input.Please try again.\r\n");
                    i--;
                }
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\r\nCategories of this Trades:\r\n");
            for (int i = 0; i < numberOfTrades; i++)
            {
                Console.Write("Trade " + (i + 1) + " :");
                Console.WriteLine(categories[i]);
            }
            Console.ResetColor();

            Console.WriteLine("\r\nContinue categorizing Trades?:\r\n");
            Console.Write("Y/N :");
            string answer = Console.ReadLine();
            if (answer.ToUpper() == "Y")
                MenuOption();
        }
        #endregion
    }
}
