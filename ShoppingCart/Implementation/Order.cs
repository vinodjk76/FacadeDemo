﻿using ShoppingCart.Interfaces;
using System;

namespace ShoppingCart.Implementation
{
    public class Order : IOrder
    {
        public int PlaceOrderDetails(int cartID, int shippingAddressID)
        {
            Console.WriteLine("\t SubSystem Order : PlaceOrderDetails");
            return 10;
        }
    }
}
