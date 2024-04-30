using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFACodeFirst.Models.Entities
{
    public class Order:BaseEntity
    {
        public string ShippingAddress { get; set; }
        public int? AppUserId { get; set; }
        
        //Relational Properties
        public virtual AppUser AppUser { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
