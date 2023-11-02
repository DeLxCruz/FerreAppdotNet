using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FerreAppdotNet.Classes
{
    public class BillDetails
    {
        public int Id { get; set; }
        public int BillNum { get; set; }
        public Bill Bill { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public Products Product { get; set; }
        public double Value { get; set; }
    }
}