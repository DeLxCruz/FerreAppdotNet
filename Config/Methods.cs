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

        public void Show()
        {
            Console.WriteLine("Products");
            foreach (var item in products)
            {
                Console.WriteLine(item.Name);
            }
        }

    }
}