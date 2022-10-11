using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommAPI_Domain.Entities.Common
{
    public class Product :  BaseEntitity
    {
        public string Name { get; set; } = string.Empty;
        public int StockNumber { get; set; }
        public long Price { get; set; }
    }
}
