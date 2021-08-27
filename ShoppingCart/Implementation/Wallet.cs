using ShoppingCart.Interfaces;
using System;

namespace ShoppingCart.Implementation
{
    public class Wallet : IWallet
    {
        public double GetUserBalance(int userID)
        {
            Console.WriteLine("\t SubSystem Wallet : GetUserBalance");
            return 100;
        }
    }
}
