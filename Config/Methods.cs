using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FerreAppdotNet.Classes;

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
            Console.WriteLine("Products");
            Console.WriteLine("--------");
            foreach (var item in products)
            {
                Console.WriteLine($"Name Product: {item.Name}");
            }
        }

        public void ShowProductsToBeFinished()
        {
            Console.WriteLine("Products to be Finished");
            Console.WriteLine("----------------------");
            var productsToBeFinished = (from p in products
                                        where p.Quantity < p.StockMin
                                        select p).ToList();

            productsToBeFinished.ForEach(p => Console.WriteLine($"- {p.Name}"));             
        }

        public void ProductsToBePurchased()
        {
            Console.WriteLine("Products to be Purchased");
            Console.WriteLine("------------------------");
            var productsToBePurchased = (from p in products
                                         where p.Quantity < p.StockMin
                                         select p).ToList();

            foreach (var item in productsToBePurchased)
            {
                Console.WriteLine($"- {item.Name} - Quantity to be purchased: {item.StockMax - item.Quantity}");
            }
        }

        public void TotalBillsFromJanuary()
        {
            Console.WriteLine("Total Bills from January");
            Console.WriteLine("------------------------");
            var totalBillsFromJanuary = (from b in bills
                                         where b.Date.Month == 01 && b.Date.Year == 2023
                                         select b).ToList();

            foreach (var item in totalBillsFromJanuary)
            {
                Console.WriteLine($"- BillNum: {item.BillNum} - Date: {item.Date} - ClientId: {item.ClientId} - Total Bill: {item.TotalBill}");
            }
        }


        public void ProductsSoldOnAGivenBill ()
        {
            Console.WriteLine("Products sold on a given bill");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Enter the bill number: ");
            int billNumber = Convert.ToInt32(Console.ReadLine());

            if (billNumber > 0)
            {
                var productsSoldOnAGivenBill = (from bd in billDetails
                                                join p in products on bd.ProductId equals p.Id
                                                where bd.BillNum == billNumber
                                                select new { p.Name, bd.BillNum, bd.Quantity, bd.Value }).ToList();

                foreach (var item in productsSoldOnAGivenBill)
                {
                    Console.WriteLine($" - Product Name: {item.Name} -BillNum: {item.BillNum} - Quantity: {item.Quantity} - Value: {item.Value}");
                }
            }
            else
            {
                Console.WriteLine("There's no bill with that number");
            }
        }

        public void TotalValueOfInventory ()
        {
            Console.WriteLine("Total value of inventory");
            Console.WriteLine("------------------------");
            var totalValueOfInventory = (from p in products
                                         select p.UnitPrice * p.Quantity).Sum();

            Console.WriteLine($"Total value of inventory: {totalValueOfInventory}");
        }
    }
}