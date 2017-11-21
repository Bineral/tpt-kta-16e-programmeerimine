namespace RestaurantReceipt
{
    using System.Linq;
    using System.Text;

    public class Receipt
    {
        private readonly string _restaurantName;

        private readonly string _restaurantAddress;

        private readonly Tab _tab;

        public Receipt(string restaurantName, string restaurantAddress, Tab tab)
        {
            this._restaurantName = restaurantName;
            this._restaurantAddress = restaurantAddress;
            this._tab = tab;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(this._restaurantName);
            sb.AppendLine(this._restaurantAddress);
            sb.AppendLine("-------------------------");

            foreach (var item in this._tab.Items)
            {
                sb.AppendLine($"Item: {item}");
            }

            var itemsTotal = this._tab.Items.Sum();

            sb.AppendLine("-------------------------");
            sb.AppendLine($"SubTotal: {itemsTotal:F2}");
            sb.AppendLine($"15% Gratuity: {itemsTotal * 0.15:F2}");
            sb.AppendLine($"Total: {itemsTotal - itemsTotal * 0.15:F2}");

            return sb.ToString();
        }
    }
}