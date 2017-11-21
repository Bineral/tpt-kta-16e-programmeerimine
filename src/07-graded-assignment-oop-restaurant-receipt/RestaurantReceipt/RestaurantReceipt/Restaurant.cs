namespace RestaurantReceipt
{
    using System;

    public class Restaurant
    {
        private readonly string _name;

        private readonly string _address;

        public Restaurant(string name, string address)
        {
            this._name = name;
            this._address = address;
        }

        public Receipt GetReceipt(Tab tab)
        {
            throw new NotImplementedException();
        }
    }
}