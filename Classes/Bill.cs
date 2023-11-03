using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FerreAppdotNet.Classes
{
    public class Bill
    {
        public int BillNum { get; set; }
        public DateOnly Date { get; set; }
        public int ClientId {get; set;}
        public double TotalBill {get; set;}
    }
}