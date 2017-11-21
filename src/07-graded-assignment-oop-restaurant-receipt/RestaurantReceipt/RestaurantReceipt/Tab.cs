namespace RestaurantReceipt
{
    using System;
    using System.Collections.Generic;

    public class Tab
    {
        public List<double> Items { get; private set; } = new List<double>();

        public void Add(double value)
        {
            Items.Add(value);
        }
    }
}