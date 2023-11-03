using FerreAppdotNet.Config;

internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("╔══════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                   UNICA Hardware Store                   ║");
            Console.WriteLine("╠══════════════════════════════════════════════════════════╣");
            Console.WriteLine("║      1. Show Inventory Products                          ║");
            Console.WriteLine("║      2. Show Products To Be Finished                     ║");
            Console.WriteLine("║      3. Show Products To Be Purchased And Quantitty      ║");
            Console.WriteLine("║      4. Show Total Bills                                 ║");
            Console.WriteLine("║      5. Show Products Sold On A Given Bill               ║");
            Console.WriteLine("║      6. Calculate Total Value Of Inventory               ║");
            Console.WriteLine("║      7. Exit                                             ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════╝");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nPor favor, elige una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Methods methods = new Methods();
                    methods.ShowProducts();
                    Console.WriteLine("Enter to continue...");
                    Console.ReadLine();
                    break;
                case "2":
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Methods methods1 = new Methods();
                    methods1.ShowProductsToBeFinished();
                    Console.WriteLine("Enter to continue...");
                    Console.ReadLine();
                    break;
                case "3":
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Methods methods2 = new Methods();
                    methods2.ProductsToBePurchased();
                    Console.WriteLine("Enter to continue...");
                    Console.ReadLine();
                    break;
                case "4":
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Methods methods3 = new Methods();
                    methods3.TotalBillsFromJanuary();
                    Console.WriteLine("Enter to continue...");
                    Console.ReadLine();
                    break;
                case "5":
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Methods methods4 = new Methods();
                    methods4.ProductsSoldOnAGivenBill();
                    Console.WriteLine("Enter to continue...");
                    Console.ReadLine();
                    break;
                case "6":
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Methods methods5 = new Methods();
                    methods5.TotalValueOfInventory();
                    Console.WriteLine("Enter to continue...");
                    Console.ReadLine();
                    break;
                case "7":
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("See You Later!");
                    Console.ResetColor();
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid option. Please choose a valid option.");
                    Console.ResetColor();
                    Console.ReadLine();
                    break;
            }
        }

    }
}