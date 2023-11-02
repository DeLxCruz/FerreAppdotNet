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

    }
}