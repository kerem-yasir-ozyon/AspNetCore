﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFACodeFirst.Models.Entities
{
    public class OrderDetail:BaseEntity
    {
        public int ProductId { get; set; }
        public int OrderId { get; set; }

        //Relational Properties
        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }
    }
}
