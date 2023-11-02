using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FerreAppdotNet.Classes;

namespace FerreAppdotNet.Config
{
    public class EntitiesList
    {
        public List<Products> _products = new ()
        {
            new () { Id = 1, Name = "Hammer" , UnitPrice = 10.5, Quantity = 10, StockMin = 5, StockMax = 50},
            new () { Id = 2, Name = "Screwdriver" , UnitPrice = 5.5, Quantity = 5, StockMin = 7, StockMax = 20},
            new () { Id = 3, Name = "Wrench" , UnitPrice = 15.5, Quantity = 8, StockMin = 10, StockMax = 70},
            new () { Id = 4, Name = "Pliers" , UnitPrice = 20.5, Quantity = 4, StockMin = 5, StockMax = 30},
            new () { Id = 5, Name = "Saw" , UnitPrice = 25.5, Quantity = 10, StockMin = 5, StockMax = 20},
            new () { Id = 6, Name = "Drill" , UnitPrice = 30.5, Quantity = 10, StockMin = 20, StockMax = 100},
        };
        
        
        public List<Client> _clients = new ()
        {
            new () { Id = 1, Name = "Juan", Email = "juan@campus.com" },
            new () { Id = 2, Name = "Pedro", Email = "pedro@campus.com" },
            new () { Id = 3, Name = "Maria", Email = "maria@campus.com" },
            new () { Id = 4, Name = "Jose", Email = "jose@campus.com" },
            new () { Id = 5, Name = "Luis", Email = "luis@campus.com" },
            new () { Id = 6, Name = "Ana", Email = "ana@campus.com" },
        };   
    }
}