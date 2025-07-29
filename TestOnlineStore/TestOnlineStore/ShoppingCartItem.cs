﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOnlineStore
{
    public class ShoppingCartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public decimal TotalPrice => Product.Price * Quantity;
    }


}
