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

        public List<Bill> _bills = new ()
        {
            new () { BillNum = 1, Date = new DateOnly(2021, 10, 10), ClientId = 1, TotalBill = 100.5 },
            new () { BillNum = 2, Date = new DateOnly(2004, 01, 04), ClientId = 2, TotalBill = 200.5 },
            new () { BillNum = 3, Date = new DateOnly(2003, 10, 10), ClientId = 3, TotalBill = 300.5 },
            new () { BillNum = 4, Date = new DateOnly(2022, 05, 11), ClientId = 4, TotalBill = 400.5 },
            new () { BillNum = 5, Date = new DateOnly(2018, 01, 21), ClientId = 5, TotalBill = 500.5 },
            new () { BillNum = 6, Date = new DateOnly(2023, 01, 15), ClientId = 6, TotalBill = 600.5 }

        };

        public List <BillDetails> _billsDetails = new ()
        {
            new () { Id = 1, BillNum = 1, ProductId = 1, Quantity = 10, Value = 100.5 },
            new () { Id = 2, BillNum = 2, ProductId = 2, Quantity = 20, Value = 200.5 },
            new () { Id = 3, BillNum = 3, ProductId = 3, Quantity = 30, Value = 300.5 },
            new () { Id = 4, BillNum = 4, ProductId = 4, Quantity = 40, Value = 400.5 },
            new () { Id = 5, BillNum = 5, ProductId = 5, Quantity = 50, Value = 500.5 },
            new () { Id = 6, BillNum = 6, ProductId = 6, Quantity = 60, Value = 600.5 }
        };
    }
}