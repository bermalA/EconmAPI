using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommAPI_Domain.Entities.Common
{
    public class BaseEntitity
    {
           public int ID { get; set; }
           public DateTime CreatedDate { get; set; }
    }
}
