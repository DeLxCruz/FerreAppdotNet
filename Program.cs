using FerreAppdotNet.Config;

internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("╔════════════════════════════════════════════════════╗");
            Console.WriteLine("║     UNICA Hardware Store                           ║");
            Console.WriteLine("╠════════════════════════════════════════════════════╣");
            Console.WriteLine("║  1. Show Inventory Products                        ║");
            Console.WriteLine("║  2. Show Products To Be Finished                   ║");
            Console.WriteLine("║  3. Show Products To Be Purchased And Quantitty    ║");
            Console.WriteLine("║  4. Show Total Bills                               ║");
            Console.WriteLine("║  5. List Inventory Products                        ║");
            Console.WriteLine("║  6. List Inventory Products                        ║");
            Console.WriteLine("║  7. Salir                                          ║");
            Console.WriteLine("╚════════════════════════════════════════════════════╝");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nPor favor, elige una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Clear();
                    Methods methods = new Methods();
                    methods.ShowProducts();
                    Console.ReadLine();
                    break;
                case "2":
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Methods methods1 = new Methods();
                    methods1.ShowProductsToBeFinished();
                    Console.ReadLine();
                    break;
                case "3":
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Methods methods2 = new Methods();
                    methods2.ProductsToBePurchased();
                    Console.ReadLine();
                    break;
                case "4":
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Methods methods3 = new Methods();
                    methods3.TotalBillsFromJanuary();
                    Console.ReadLine();
                    break;
                case "7":
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("¡Hasta luego!");
                    Console.ResetColor();
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opción no válida. Por favor, elige una opción válida.");
                    Console.ResetColor();
                    Console.ReadLine();
                    break;
            }
        }

    }
}