using ShoppingCart.Interfaces;
using System;

namespace ShoppingCart.Implementation
{
    public class AddressDetails : IAddress
    {
        public Models.Address GetAddressDetails(int userID)
        {
            Console.WriteLine("\t SubSystem Address : GetAddressDetails");
            return new Models.Address();
        }

    }
}
