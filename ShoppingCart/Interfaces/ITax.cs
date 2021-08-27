﻿namespace ShoppingCart.Interfaces
{
    public interface ITax
    {
        double GetTaxByState(string state);
        void ApplyTax(int cartID, double taxPercent);
    }
}
