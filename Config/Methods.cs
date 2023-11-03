using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using FerreAppdotNet.Classes;
using BetterConsoleTables;

namespace FerreAppdotNet.Config
{
    public class Methods
    {
        static EntitiesList entitiesList = new();
        static List<Products> products = entitiesList._products;
        static List<Client> clients = entitiesList._clients;
        static List<Bill> bills = entitiesList._bills;
        static List<BillDetails> billDetails = entitiesList._billsDetails;

        public void ShowProducts()
        {
            Console.WriteLine("Inventory Products");
            Console.WriteLine("══════════════════");
            var table = new Table("Name", "Unit Price", "Quantity");

            foreach (var item in products)
            {
                table.AddRow(item.Name, item.UnitPrice, item.Quantity);
            }
            table.Config = TableConfiguration.UnicodeAlt();
            Console.WriteLine(table.ToString());
        }

        public void ShowProductsToBeFinished()
        {
            Console.WriteLine("Products to be finished");
            Console.WriteLine("═══════════════════════");
            var table = new Table("Name");

            var productsToBeFinished = (from p in products
                                        where p.Quantity < p.StockMin
                                        select p).ToList();

            productsToBeFinished.ForEach(p => table.AddRow(p.Name));
            table.Config = TableConfiguration.UnicodeAlt();
            Console.WriteLine(table.ToString());             
        }

        public void ProductsToBePurchased()
        {
            Console.WriteLine("Products to be Purchased");
            Console.WriteLine("════════════════════════");
            var table = new Table("Name", "Quantity to be purchased");

            var productsToBePurchased = (from p in products
                                         where p.Quantity < p.StockMin
                                         select p).ToList();

            foreach (var item in productsToBePurchased)
            {
                table.AddRow(item.Name, item.StockMax - item.Quantity);
            }
            table.Config = TableConfiguration.UnicodeAlt();
            Console.WriteLine(table.ToString());
        }

        public void TotalBillsFromJanuary()
        {
            Console.WriteLine("Total Bills from January");
            Console.WriteLine("════════════════════════");
            var table = new Table("BillNum", "Date", "ClientId", "Total Bill");

            var totalBillsFromJanuary = (from b in bills
                                         where b.Date.Month == 01 && b.Date.Year == 2023
                                         select b).ToList();

            foreach (var item in totalBillsFromJanuary)
            {
                table.AddRow(item.BillNum, item.Date, item.ClientId, item.TotalBill);
            }
            table.Config = TableConfiguration.UnicodeAlt();
            Console.WriteLine(table.ToString());
        }


        public void ProductsSoldOnAGivenBill ()
        {
            Console.WriteLine("Products sold on a given bill");
            Console.WriteLine("═════════════════════════════");
            Console.WriteLine("Enter the bill number: ");
            int billNumber = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            var table = new Table("Name", "BillNum", "Quantity", "Value");

            if (billNumber > 0)
            {
                var productsSoldOnAGivenBill = (from bd in billDetails
                                                join p in products on bd.ProductId equals p.Id
                                                where bd.BillNum == billNumber
                                                select new { p.Name, bd.BillNum, bd.Quantity, bd.Value }).ToList();

                foreach (var item in productsSoldOnAGivenBill)
                {
                    table.AddRow(item.Name, item.BillNum, item.Quantity, item.Value);
                }
                table.Config = TableConfiguration.UnicodeAlt();
                Console.WriteLine(table.ToString());
            }
            else
            {
                Console.WriteLine("There's no bill with that number");
            }
        }

        public void TotalValueOfInventory ()
        {
            var table = new Table("Total value of inventory: ");

            var totalValueOfInventory = (from p in products
                                         select p.UnitPrice * p.Quantity).Sum();

            table.AddRow(totalValueOfInventory);
            table.Config = TableConfiguration.UnicodeAlt();
            Console.WriteLine(table.ToString());
        }
    }
}